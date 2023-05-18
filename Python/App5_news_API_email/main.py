import requests
from send_email import send_email

api_key = "9421379a45cc428eaaef6960f0e5899e"
url = "https://newsapi.org/v2/everything?q=tesla&" \
      "from=2023-04-18&sortBy=publishedAt&" \
      "apiKey=9421379a45cc428eaaef6960f0e5899e"

request = requests.get(url)  # make request
content = request.json()  # get dictionary with data

# print(content["articles"])
# print(type(content))
content_to_send = ""

# access the article titles and description
for article in content["articles"]:
    # print(article["title"])
    # print(type(article["title"]))
    # print(f"{article['title']} - {article['description']}")
    content_to_send = content_to_send + f"{article['title']} - {article['description']} \n\n"
    # print(article["description"])

content_to_send = content_to_send.encode("utf-8")
send_email(content_to_send)
print(content_to_send)
