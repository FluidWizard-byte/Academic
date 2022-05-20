import pandas as pd

df=pd.read_csv('movies_dataset.csv')

df.drop_duplicates(subset ="IMDB_ID", inplace = True)

df.to_csv('filtered_movies_dataset.csv')