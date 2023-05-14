import smtplib
import ssl
import os  # environment variable for hiding password (from win env.variable)


def send_email(message):
    host = "smtp.gmail.com"
    port = 465
    username = "jakub.mukarovsky@gmail.com"
    password = os.getenv("PASSWORD")  # hiding pass in environment variable
    receiver = "jakub.mukarovsky@gmail.com"
    context = ssl.create_default_context()

    with smtplib.SMTP_SSL(host, port, context=context) as server:
        server.login(username, password)
        server.sendmail(username, receiver, message)

# send_email("test")
