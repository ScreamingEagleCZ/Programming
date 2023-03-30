import functions
import PySimpleGUI as SG

label = SG.Text("Type in a To-Do")
input_box = SG.InputText(tooltip="Enter To-Do")
add_button = SG.Button("Add")

window = SG.Window('My To-Do App', [[label], [input_box, add_button]])
window.read()
window.close()
