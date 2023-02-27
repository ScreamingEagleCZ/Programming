print("To-Do list")
# todos = [] - unusable with file handling

while True:
    user_action = input("Type Add, Show, Edit, Complete or Quit: ")
    user_action = user_action.strip()  # strip cuts blank places from string
    match user_action:
        case 'add' | 'a':
            todo = input("What do U want to add: ") + "\n"  # adds break line to input (and to todos.txt)

            file = open('Files/todos.txt', 'r')  # opens file with read privileges
            todos = file.readlines()  # reads the data from file
            file.close()  # close the file after no longer needed

            todos.append(todo)  # adds to the end of list

            file = open('Files/todos.txt', 'w')  # opens file with Write privileges
            file.writelines(todos)
            file.close()
        case 'show' | 'display' | 's':
            file = open('Files/todos.txt', 'r')  # opens file for reading
            todos = file.readlines()
            file.close()
            # cutted_todos = [i.strip('\n') for i in todos]
            # (then cutted_todos will be used in next for loop without strip method
            # list comprehension short for loop - creates new list without \n in each word
            for i, each in enumerate(todos):  # enumerate returns index(i) of element + the list element in ()
                each = each.strip('\n')
                print(f"{i + 1}) {each.capitalize()}")  # fstring - helps writing variables in a string in single quotes
        case 'edit' | 'e':
            file = open('Files/todos.txt', 'r')  # opens file for reading
            todos = file.readlines()
            file.close()

            number = int(input("Number of ToDo to Edit: "))
            number = number - 1  # because we want to start from 1 and not zero
            new_todo = input("What will be the new ToDo?: ") + "\n"
            todos[number] = new_todo

            file = open('Files/todos.txt', 'w')
            file.writelines(todos)
            file.close()
        case 'complete' | 'c':  # technically delete
            file = open("Files/todos.txt", 'r')
            todos = file.readlines()
            file.close()

            number = int(input("Number of which one to complete?: "))
            number = number - 1
            todos.pop(number)  # deletes and returns element

            file = open("Files/todos.txt", 'w')
            file.writelines(todos)
            file.close()
        case 'quit' | 'q':
            break  # stops the while TRUE loop
        case _:
            print("Not a valid command")
print("Bye and have a nice day!")
