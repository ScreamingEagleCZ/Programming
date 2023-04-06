import PySimpleGUI as sg

label1 = sg.Text("Enter feet:")
input_box1 = sg.Input()

label2 = sg.Text("Enter inches:")
input_box2 = sg.Input()

button1 = sg.Button("Convert")

window = sg.Window("Convertor",
                   [[label1, input_box1],
                    [label2, input_box2],
                    [button1]])
window.read()
window.close()

