import functions

print("To-Do list by Jakub Mukarovsky")

while True:
    user_action = input("Type add, show, edit, complete or quit: ")
    user_action = user_action.strip()  # strip cuts blank places from string

    if user_action.startswith('add') | user_action.startswith('new'):
        if len(user_action) <= 3:
            todo = input("What do U want to add: ") + "\n"  # adds break line to input (and to todos.txt)
        else:
            todo = user_action[4:] + "\n"

        todos = functions.get_todos()
        todos.append(todo)  # adds to the end of list
        functions.write_todos(todos_local=todos)  # arg specified by keyword (can be swapped with different arg in line

    elif user_action.startswith('show'):
        todos = functions.get_todos()

        for i, each in enumerate(todos):  # enumerate returns index(i) of element + the list element in ()
            each = each.strip('\n')
            print(f"{i + 1}) {each.capitalize()}")  # fstring - helps writing variables in a string in single quotes

    elif user_action.startswith('edit'):
        try:
            if len(user_action) <= 4:
                number = int(input("Number of ToDo to Edit: "))
            else:
                number = int(user_action[5:])

            todos = functions.get_todos()

            number = number - 1  # because we want to start from 1 and not zero
            new_todo = input("What will be the new ToDo?: ") + "\n"
            todos[number] = new_todo
            functions.write_todos(todos)
        except ValueError:
            print("You were supposed to enter a number...")
            continue
        except IndexError:
            print("Out of bounds buddy...choose existing number...")
            continue

    elif user_action.startswith('complete'):  # technically delete
        try:
            if len(user_action) <= 8:
                number = int(input("Number of which one to complete?: "))
            else:
                number = int(user_action[9:])

            todos = functions.get_todos()

            number = number - 1
            todo_to_remove = todos[number].strip('\n')  # strip - so the later print is not on 2 rows
            todos.pop(number)  # deletes and returns element

            functions.write_todos(todos)

            print(f"Todo *** {todo_to_remove} *** was removed...")
        except ValueError:
            print("You were supposed to enter a number...")
            continue
        except IndexError:
            print("Out of bounds buddy...choose existing number...")
            continue

    elif user_action.startswith('quit'):
        break  # stops the while TRUE loop

    else:
        print("Not a valid command")
print("Bye and have a nice day!")
