print("To-Do list")

user_prompt = "Type add, show, edit, delete or quit: "
todos = []

while True:
    user_action = input(user_prompt)
    user_action = user_action.strip()
    match user_action:
        case 'add' | 'a':
            todo = input("What do U want to add: ")
            todos.append(todo)
        case 'show' | 'display' | 's':
            i = 1
            for each in todos:
                print(str(i) + ') ' + each.capitalize())
                i = i + 1
        case 'edit' | 'e':
            number = int(input("Number of ToDo to Edit: "))
            number = number - 1
            new_todo = input("What will be the new ToDo?: ")
            todos[number] = new_todo
        case 'delete' | 'd':
            number = int(input("Number of which one to delete?: "))
            number = number - 1
            todos.pop(number)
        case 'quit' | 'q':
            break
        case _:
            print("Not a valid command")
print("Bye and have a nice day!")



