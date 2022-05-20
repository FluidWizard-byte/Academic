#importing required libraries
import pandas as pd
from sklearn.metrics.pairwise import cosine_similarity
from sklearn.feature_extraction.text import CountVectorizer

# loading data set
df=pd.read_csv('filtered_movies_dataset.csv')

#columns (features) needed for recommendation
columns=['Title','Genre','Released','Runtime','Description','Director','Cast']
df[columns].head()

#checking for null values is not required because our dataset is pre formatted but the code below can be used to identifu null values
#null values can be removed as required it there were ant
#df[columns].isnull().values.any()

#combining important features required to get recommenation
def get_important_features(movie_data):
    important_features=[]
    for i in range(0,movie_data.shape[0]):
        important_features.append(movie_data['Title'][i]+' '+movie_data['Genre'][i]+' '+str(movie_data['Released'][i])
                                +' '+str(movie_data['Runtime'][i])+' '+movie_data['Description'][i]
                                +' '+movie_data['Director'][i]+' '+movie_data['Cast'][i])
    return important_features
    

#create column to store combined features
df['important_features']=get_important_features(df)


#converting important features to numeric value count vector
#cvm=CountVectorizer(stop_words='english').fit_transform(df['important_features'])
cvm=CountVectorizer().fit_transform(df['important_features'])

#cosine similarity matrix from cvm
cs=cosine_similarity(cvm)


#loop to keep the program running

loop=True

while (loop):

    take_input=True
    while (take_input):
        
        #id from title
        try:
            title=input("\nEnter a movie you like: ")
            movie_id=df[df.Title == title]['index'].values[0]
            take_input=False
        except:
            print('\nThe movie you entered was not in the dataset or incorrect title was used.\n\n+ Use original release titles for movies \n\n\tExample: use "Sen to Chihiro no kamikakushi" intead of "Spirited Away"\n\n+ Also keep in mind movie titles need to be accurate and are case sensitive\n\n\tExample: use "The Hobbit: An Unexpected Journey" instead of "The Hobbit".\n')
        
        
    # creating list of similarity scores
    scores= list(enumerate(cs[movie_id]))

    #sorting the list in escending order as, highest value is the most similar
    #lamda function takes input x an for element in x[1](similarity score) is returned 
    sort_similarity_scores= sorted(scores,key =lambda x:x[1], reverse =True)


    #excluding the 1st element as it will be comparison with itelf with score 1

    sort_similarity_scores = sort_similarity_scores[1:]

    i=0
    print('\nTop 10 movies similar to '+title+' are: \n')
    for item in sort_similarity_scores:
        movie_title=df[df.index == item[0]]['Title'].values[0]
        imdb_id=df[df.index == item[0]]['IMDB_ID'].values[0]
        link="https://www.imdb.com/title/"+imdb_id+"/"
        print(i+1,movie_title)
        print('      IMDB link: '+link+'\n')
        i=i+1
        if i>9:
            break

    a=input('\nGet more recommendations from another movie yoy have watched [y/n]?: ')
    if(a=='Y' or a=='y'):
        loop=True
    else:
        print('\nEnjoy your recommendations (:\n')
        loop=False