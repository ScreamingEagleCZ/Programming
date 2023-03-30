import functions
import PySimpleGUI as sg

label = sg.Text("Type in a To-Do")
input_box = sg.InputText(tooltip="Enter To-Do")
add_button = sg.Button("Add")

window = sg.Window('My To-Do App', [[label], [input_box, add_button]])
window.read()
print("Done with app ;)")
window.close()
