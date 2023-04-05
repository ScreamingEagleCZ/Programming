import streamlit as st
# streamlit run web.py - to run the webpage from terminal
import functions


def add_todo():
    todo = st.session_state["new_todo"] + "\n"
    todos.append(todo)
    functions.write_todos(todos)


todos = functions.get_todos()

st.title("My To-Do App")
st.subheader("...by Jakub Mukařovský")
st.write("App for productivity increase")

for index, todo in enumerate(todos):
    checkbox = st.checkbox(todo, key=todo)
    if checkbox:
        todos.pop(index)
        functions.write_todos(todos)
        del st.session_state[todo]
        st.experimental_rerun()


st.text_input(label="To-Do Add/Edit here: ",
              placeholder="Enter a To-Do...",
              on_change=add_todo,
              key='new_todo')

print("Hello")

# st.session_state  # shows state during development for seeing important stuff
