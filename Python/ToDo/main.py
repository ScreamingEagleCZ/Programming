print("To-Do list")
# todos = [] - unusable with file handling

while True:
    user_action = input("Type Add, Show, Edit, Complete or Quit: ")
    user_action = user_action.strip()  # strip cuts blank places from string
    match user_action:
        case 'add' | 'a':
            todo = input("What do U want to add: ") + "\n"  # adds break line to input (and to todos.txt)
            with open('Files/todos.txt', 'r') as file:  # open file with Read permission as file

                todos = file.readlines()

            todos.append(todo)  # adds to the end of list
            with open('Files/todos.txt', 'w') as file:
                file.writelines(todos)

        case 'show' | 'display' | 's':
            with open('Files/todos.txt', 'r') as file:
                todos = file.readlines()

            for i, each in enumerate(todos):  # enumerate returns index(i) of element + the list element in ()
                each = each.strip('\n')
                print(f"{i + 1}) {each.capitalize()}")  # fstring - helps writing variables in a string in single quotes

        case 'edit' | 'e':
            with open('Files/todos.txt', 'r') as file:
                todos = file.readlines()

            number = int(input("Number of ToDo to Edit: "))
            number = number - 1  # because we want to start from 1 and not zero
            new_todo = input("What will be the new ToDo?: ") + "\n"
            todos[number] = new_todo

            with open('Files/todos.txt', 'w') as file:
                file.writelines(todos)

        case 'complete' | 'c':  # technically delete
            with open('Files/todos.txt', 'r') as file:
                todos = file.readlines()

            number = int(input("Number of which one to complete?: "))
            number = number - 1
            todo_to_remove = todos[number].strip('\n')  # strip - so the later print is not on 2 rows
            todos.pop(number)  # deletes and returns element

            with open('Files/todos.txt', 'w') as file:
                file.writelines(todos)

            print(f"Todo ***{todo_to_remove}*** was removed...")
        case 'quit' | 'q':
            break  # stops the while TRUE loop

        case _:
            print("Not a valid command")
print("Bye and have a nice day!")
