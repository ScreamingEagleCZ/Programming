import streamlit as st
import pandas  # manages csv files - makes tab of parsed data

st.set_page_config(layout="wide")

col1, col2 = st.columns(2)

with col1:
    st.image("images/photo.jpg",)

with col2:
    st.title("Jakub Mukařovský")
    content = """
    Hi, I am Jakub! I am trying to become Software programmer. I graduated in 2006 on Secondary School from Software
    and Electronics. After that I worked in Pharmaceutical company for 7 years as Manufacturing Support technician.
    From 2014 I am working in Automation company, where I started as Mechatronic who assembles and wires machines.
    18 Months later I switched to PLC programmer in same company, responsible for preparation and commissioning of
    PLC software for machine, it´s peripheries and communication between all of those and customer network.
    """
    st.info(content)

short_info = """
This page is built completely in Python...
Below you can see some apps I built using Python.
If you have any questions or just want to talk, you can contact me!
"""
st.write(short_info)

col3, empty_col, col4 = st.columns([1.5, 0.5, 1.5])

df = pandas.read_csv("data.csv", sep=";")  # opens csv data file and separates data by ;

with col3:
    for index, row in df[:10].iterrows():
        st.header(row["title"])
        st.write(row["description"])
        st.image("images/" + row["image"])
        st.write(f"[Source Code]({row['url']})")  # later will be added GitHub link

with col4:
    for index, row in df[10:].iterrows():
        st.header(row["title"])
        st.write(row["description"])
        st.image("images/" + row["image"])
        st.write(f"[Source Code]({row['url']})")  # later will be added github link
