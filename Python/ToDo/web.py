import streamlit as st
import functions

todos = functions.get_todos()

st.title("My To-Do App")
st.subheader("...by Jakub Mukařovský")
st.write("App for productivity increase")

for each in todos:
    st.checkbox(each)

st.text_input(label="To-Do Add/Edit here: ", placeholder="Enter a To-Do...")
