import functions
import PySimpleGUI as Sg
import time
import os


if not os.path.exists("todos.txt"):
    with open("todos.txt", "w") as file:
        pass

Sg.theme("DarkTeal12")
clock = Sg.Text('', key='clock')
label = Sg.Text("Type in a To-Do")
input_box = Sg.InputText(tooltip="Enter To-Do", key="todo")
add_button = Sg.Button(key="Add",
                       size=20,
                       image_source="Files/add.png",
                       mouseover_colors="DarkGreen",
                       tooltip="Add To-do")
list_box = Sg.Listbox(values=functions.get_todos(),
                      key="todos",
                      enable_events=True,
                      size=[45, 10])
edit_button = Sg.Button("Edit")
complete_button = Sg.Button(key="Complete",
                            size=20,
                            image_source="Files/complete.png",
                            mouseover_colors="DarkGreen",
                            tooltip="Complete To-do")
exit_button = Sg.Button("Exit")

window = Sg.Window('My To-Do App',
                   layout=[[label, clock],
                           [input_box, add_button],
                           [list_box, edit_button, complete_button],
                           [exit_button]],
                   font=('Helvetica', 14))
while True:
    event, values = window.read(timeout=1000)
    window["clock"].update(value=time.strftime("      %b %d, %Y %H:%M:%S"))
    print(1, event)  # used for reference during programming
#    print(2, values)
#    print(3, values['todos'])

    match event:
        case "Add":
            todos = functions.get_todos()
            new_todo = values['todo'] + "\n"
            todos.append(new_todo)
            functions.write_todos(todos)
            window['todos'].update(values=todos)
        case "Edit":
            try:
                todo_to_edit = values['todos'][0]
                new_todo = values['todo'] + "\n"

                todos = functions.get_todos()
                index = todos.index(todo_to_edit)
                todos[index] = new_todo
                functions.write_todos(todos)
                window['todos'].update(values=todos)
            except IndexError:
                Sg.Popup("Please select an item first...", font=("Helvetica", 16))
        case "Complete":
            try:
                todo_to_complete = values['todos'][0]
                todos = functions.get_todos()
                todos.remove(todo_to_complete)
                functions.write_todos(todos)
                window['todos'].update(values=todos)
                window['todo'].update(value="")
            except IndexError:
                Sg.Popup("Please select an item first...", font=("Helvetica", 16))
        case "todos":
            window['todo'].update(value=values['todos'][0])
        case "Exit":
            break
        case Sg.WIN_CLOSED:
            break

print("\nDone with app ;)")
window.close()



