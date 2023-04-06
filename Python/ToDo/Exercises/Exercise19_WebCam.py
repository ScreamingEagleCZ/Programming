"""
In terminal:
streamlit run Exercises/Exercise19_WebCam.py
"""

import streamlit as st
from PIL import Image   # library for using images (Pillow)

uploaded_image = st.file_uploader("Upload Image")

with st.expander("Start Camera"):
    # start camera
    camera_image = st.camera_input("Camera")

if camera_image:
    # Create a pillow image instance
    img = Image.open(camera_image)

    # Convert the pillow image to grayscale
    gray_img = img.convert("L")

    # Render the grayscale img on the web page
    st.image(gray_img)

if uploaded_image:
    img2 = Image.open(uploaded_image)
    gray_img2 = img2.convert("L")
    st.image(gray_img2)
