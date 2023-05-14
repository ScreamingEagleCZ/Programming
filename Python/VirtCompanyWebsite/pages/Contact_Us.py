import streamlit as st
from send_email import send_email

st.header("Contact Us")

with st.form(key="email_forms"):
    user_email = st.text_input("Your Email address:")
    option = st.selectbox(
        "What topic do You want to discuss?",
        ('Job inquiries', 'Project proposals', 'Others'))
    st.write("You selected:", option)
    raw_message = st.text_area("Your message here:")
    message = f"""\
Subject: New Email from: {user_email}

From: {user_email}

Topic: {option}

Message: {raw_message}
"""

    button = st.form_submit_button("Submit")
    if button:
        send_email(message)
        st.info("Email was sent successfully...")

