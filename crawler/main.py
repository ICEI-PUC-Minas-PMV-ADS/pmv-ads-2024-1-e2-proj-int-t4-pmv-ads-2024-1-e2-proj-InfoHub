from datetime import date
import os

import pyodbc
import requests
from lxml import html


CATEGORIES = [
    "politica", "mundo", "economia", "tecnologia", "negocios", 
    "viagens", "clima", "moda", "comida", "esporte"
]


def request_url_g1(url_news_site: str, category: str) -> list:
    list_news_data = []
    response = requests.get(url_news_site)

    if response.ok:
        content = html.fromstring(response.content)
        for title, date, theme, url in zip(
            content.xpath('////div[@class="bastian-feed-item"]//div/div[2]/div/h2//p/text()'),
            content.xpath('//div[@class="bastian-feed-item"]//span[@class="feed-post-datetime"]/text()'),
            content.xpath('//div[@class="bastian-feed-item"]//span[@class="feed-post-metadata-section"]/text()'),
            content.xpath('//div[@class="bastian-feed-item"]//a/@href')
        ):
            date = format_date(date)
            title = str(title).strip()
            list_news_data.append((theme.strip(), title, date, url, category, "G1 Noticias"))

        return list_news_data

def request_url_bbc_brasil(url_news_site: str, category: str) -> list:
    list_news_data = []
    response = requests.get(url_news_site)

    if response.ok:
        content = html.fromstring(response.content)

        theme = content.xpath('//div[@class="bbc-wthhiv"]//h1//text()')[0]
        theme = theme.encode('iso-8859-1')
        theme = theme.decode('utf-8')

        for title, date, url in zip(
            content.xpath('//div[@class="bbc-bjn8wh e1v051r10"]//h2//text()'),
            content.xpath('//div[@class="bbc-bjn8wh e1v051r10"]//time//text()'),
            content.xpath('//div[@class="bbc-bjn8wh e1v051r10"]//h2//a/@href')
            
        ):
            date = format_date(date)
            title = title.encode('iso-8859-1')

            list_news_data.append((
                theme, title.decode('utf-8'), date, url, category, "BBC Noticias"
            ))

    return list_news_data

def format_date(date_text: str):
    months = {
        "janeiro": 1,
        "fevereiro": 2,
        "março": 3,
        "abril": 4,
        "maio": 5,
        "junho": 6,
        "julho": 7,
        "agosto": 8,
        "setembro": 9,
        "outubro": 10,
        "novembro": 11,
        "dezembro": 12
    }
    try: 
        day, month_text, year = date_text.split()

        day = int(day)
        year = int(year)

        month = months [month_text]
        date_object = date(year, month, day)

        return str(date_object)
    except ValueError:
        return str(date.today())

def connect_database() -> pyodbc.Connection:
    server = 'sqldbinfohub.database.windows.net'
    database = 'infohub'
    username = os.getenv("db_username")
    password = os.getenv("db_password")
    driver = '{ODBC Driver 17 for SQL Server}'

    connection_string = f'DRIVER={driver};SERVER={server};DATABASE={database};UID={username};PWD={password}'
    return pyodbc.connect(connection_string)

def insert_data(connection: pyodbc.Connection, list_news: list):
    cursor = connection.cursor()

    sql_insert = '''
        INSERT INTO noticias (Tema, Titulo, DataPublicacao, Url, Categoria, Autor)
        VALUES (?, ?, ?, ?, ?, ?)
    '''

    data_to_insert = list_news
    for row in data_to_insert:
        cursor.execute(sql_insert, row)

    connection.commit()

    
if __name__ == "__main__":

    for category in CATEGORIES:
        connection = connect_database()
        list_news = request_url_g1(f"https://g1.globo.com/{category}", category=category)
        if list_news:
           insert_data(connection, list_news)

        list_news = request_url_bbc_brasil("https://www.bbc.com/portuguese/topics/cr50y580rjxt", category)
        if list_news:
           insert_data(connection, list_news)

        connection.close()
