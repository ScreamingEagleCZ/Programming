import streamlit as st
import requests

# Prepare API key and url
api_key = "II4RrTZYhvmPlpcyPg5FahTqMRdOhHgW5AgdOh2x"
url = f"https://api.nasa.gov/planetary/apod?api_key={api_key}"

# Get the request data as a dictionary
request1 = requests.get(url)
content = request1.json()

# Extract title, date, image url and explanation
title = content["title"]
date = content["date"]
image_url = content["url"]
explanation = content["explanation"]

# download the image
image_filepath = "image.png"
request2 = requests.get(image_url)
with open(image_filepath, "wb") as file:
    file.write(request2.content)

# Construct page
st.header("NASA Picture of the Day")
st.title(title)
st.write(f"Date: {date}")
st.image(image_filepath)
st.write(explanation)
