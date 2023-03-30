import functions
import PySimpleGUI as Sg

label = Sg.Text("Type in a To-Do")
input_box = Sg.InputText(tooltip="Enter To-Do", key="todo")
add_button = Sg.Button("Add")

window = Sg.Window('My To-Do App',
                   layout=[[label], [input_box, add_button]],
                   font=('Helvetica', 14))
while True:
    event, values = window.read()
    print(event)
    print(values)
    match event:
        case"Add":
            todos = functions.get_todos()
            new_todo = values['todo'] + "\n"
            todos.append(new_todo)
            functions.write_todos(todos)
        case Sg.WIN_CLOSED():
            break

print("\nDone with app ;)")
window.close()



