import streamlit as st
import pandas

st.set_page_config(layout="wide")

st.title("ACME Corporation")
content = """
WNNA ANKLNLANF KALNFLKKNAKak nla knalfnal n klanlfkn alknsf lkan lsknflak f 
alkkn alfalksf al lklklaksf lkanslfn lakngllewioo lm lknlkangkangaga
alsfjbui olainglla lkanflan lknalfnalnfliianf agag.
"""
st.info(content)

st.title("Our Team")
col1, empty_col, col2, empty_col2, col3 = st.columns([1.5, 0.5, 1.5, 0.5, 1.5])

df = pandas.read_csv("data.csv", sep=",")

with col1:
    for index, row in df[:4].iterrows():
        first = row['first name'].capitalize()
        last = row['last name'].capitalize()
        st.header(f"{first} {last}")
        st.write(row["role"])
        st.image("images/" + row["image"])

with col2:
    for index, row in df[4:8].iterrows():
        first = row['first name'].capitalize()
        last = row['last name'].capitalize()
        st.header(f"{first} {last}")
        st.write(row["role"])
        st.image("images/" + row["image"])

with col3:
    for index, row in df[8:].iterrows():
        first = row['first name'].capitalize()
        last = row['last name'].capitalize()
        st.header(f"{first} {last}")
        st.write(row["role"])
        st.image("images/" + row["image"])
