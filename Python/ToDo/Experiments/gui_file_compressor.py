import PySimpleGUI as Sg
from zip_creator import make_archive


label1 = Sg.Text("Select files for compression")
input1 = Sg.Input()
button1 = Sg.FilesBrowse("Choose", key="files")

label2 = Sg.Text("Select destination folder")
input2 = Sg.Input()
button2 = Sg.FolderBrowse("Choose", key="folder")

button3 = Sg.Button("Compress")
output_label = Sg.Text("", key="output", text_color="black")

window = Sg.Window("File Compressor",
                   [[label1, input1, button1],
                    [label2, input2, button2],
                    [button3, output_label]])
while True:
    event, values = window.read()
    filepaths = values["files"].split(';')
    folder = values["folder"]
    make_archive(filepaths, folder)
    window["output"].update(value="Compression completed!")


window.close()
