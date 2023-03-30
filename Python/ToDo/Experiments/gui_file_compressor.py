import PySimpleGUI as sg

label1 = sg.Text("Select files for compression")
input1 = sg.Input()
button1 = sg.FilesBrowse("Choose")

label2 = sg.Text("Select destination folder")
input2 = sg.Input()
button2 = sg.FolderBrowse("Choose")

button3 = sg.Button("Compress")

window = sg.Window("File Compressor",
                   [[label1, input1, button1],
                    [label2, input2, button2],
                    [button3]])

window.read()
window.close()
