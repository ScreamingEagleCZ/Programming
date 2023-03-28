def get_todos(filepath="Files/todos.txt"):  # default argument if none passed to function
    """ Read a text file and returns list of
    to-do items """  # docstring - if used in code via help(function) it shows this string as description
    with open(filepath, 'r') as file:
        todos_local = file.readlines()
    return todos_local


def write_todos(todos_local, filepath="Files/todos.txt"):  # default argument comes after non default
    """ Open file and write list of to-do items """
    with open(filepath, 'w') as file:
        file.writelines(todos_local)


