
import requests
import pandas as pd
from bs4 import BeautifulSoup


n=51
while (n!=7001):
    x=str(n)
    url='https://www.imdb.com/search/title/?title_type=feature&num_votes=10000,&countries=us&sort=user_rating,desc&start='+x+'&ref_=adv_nxt'

    headers={"User-Agent": 'Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:95.0) Gecko/20100101 Firefox/95.0'}

    response=requests.get(url, headers=headers)

    soup=BeautifulSoup(response.content,'html.parser')

    imdb_id=[]
    movie_name=[] 
    release_year=[] 
    movie_runtime=[] 
    movie_genre=[] 
    movie_description=[]
    movie_director=[]
    movie_cast=[]

    #this div contains movie
    movie_data=soup.findAll('div', attrs={'class': 'lister-item mode-advanced'})

    for data in movie_data:
        name=data.h3.a.text
        movie_name.append(name)

        id=data.a.get('href').split('/')[2]
        imdb_id.append(id)

        year=data.h3.find('span', class_='lister-item-year text-muted unbold').text
        year_num=''.join([i for i in year if i.isdigit()])
        release_year.append(year_num)

        genre=data.p.find('span',class_='genre').text.replace('            ','').replace('\n','')
        movie_genre.append(genre)

        runtime=data.p.find('span', class_='runtime').text.replace(' min','')
        movie_runtime.append(runtime)

        description = data.find_all('p', class_ = 'text-muted')
        description_ = description[1].text.replace('\n', '') if len(description) >1 else '*****'
        movie_description.append(description_)

        cast = data.find("p", class_ = '')
        casts = cast.text.replace(' \n','').replace('Director:','').replace('Stars:','').replace('Directors:','')
        director=casts.split('|')[0].replace('\n','').replace('    ','')
        try:
            leads=casts.rsplit('|',)[1].replace('\n','').replace('    ','')
    
        except:
            leads=director

    
        movie_director.append(director)
        movie_cast.append(leads)



    movie_df=pd.DataFrame({'IMDB_ID':imdb_id,'Title':movie_name,'Released':release_year,'Runtime':movie_runtime,'Genre':movie_genre,'Description':movie_description,'Director':movie_director,'Cast':movie_cast})

    
    movie_df.to_csv('6983_movies_dataset.csv', mode='a', index=False, header=False)
    print("successful data =",n)
    n+=50
    

