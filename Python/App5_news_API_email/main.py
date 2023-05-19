import requests
from send_email import send_email

topic = "tesla"
api_key = "9421379a45cc428eaaef6960f0e5899e"

url = "https://newsapi.org/v2/everything?" \
      f"q={topic}s&" \
      "from=2023-04-19&sortBy=publishedAt&" \
      "apiKey=9421379a45cc428eaaef6960f0e5899e" \
      "&language=en"

request = requests.get(url)  # make request
content = request.json()  # get dictionary with data

# print(content["articles"])
# print(type(content))
content_to_send = "Subject: Today`s news \n"

# access the article titles and description
for article in content["articles"][:20]:
    if article["title"] is not None:
        if article["description"] is not None:
            if article["url"] is not None:
                # print(article["title"])
                # print(type(article["title"]))
                # print(f"{article['title']} - {article['description']}")
                content_to_send = content_to_send + article["title"] + "\n" \
                                  + article["description"] + "\n" \
                                  + article["url"] + 2*"\n"
                # print(article["description"])

content_to_send = content_to_send.encode("utf-8")
send_email(content_to_send)
print(content_to_send)
