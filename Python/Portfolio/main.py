import streamlit as st

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