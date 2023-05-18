import requests

api_key = "9421379a45cc428eaaef6960f0e5899e"
url = "https://newsapi.org/v2/everything?q=tesla&" \
      "from=2023-04-18&sortBy=publishedAt&" \
      "apiKey=9421379a45cc428eaaef6960f0e5899e"

request = requests.get(url)  # make request
content = request.json()  # get dictionary with data

print(content["articles"])
print(type(content))

# access the article titles and description
for article in content["articles"]:
    print(article["title"])
    print(article["description"])

