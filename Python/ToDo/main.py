print("To-Do list")

user_prompt = "Type add, show, edit, delete or quit: "
todos = []

while True:
    user_action = input(user_prompt)
    user_action = user_action.strip()
    match user_action:
        case 'add' | 'a':
            todo = input("What do U want to add: ")
            todos.append(todo)  # adds to the end of list
        case 'show' | 'display' | 's':
            for i, each in enumerate(todos):  # enumerate returns index(i) of element + the list element in ()
                print(f"{i + 1}) {each}")  # fstring - helps writing exactly variables in a string in single quotes
        case 'edit' | 'e':
            number = int(input("Number of ToDo to Edit: "))
            number = number - 1  # because we want to start from 1 and not zero
            new_todo = input("What will be the new ToDo?: ")
            todos[number] = new_todo
        case 'delete' | 'd':
            number = int(input("Number of which one to delete?: "))
            number = number - 1
            todos.pop(number)  # deletes and returns element
        case 'quit' | 'q':
            break  # stops the while TRUE loop
        case _:
            print("Not a valid command")
print("Bye and have a nice day!")



