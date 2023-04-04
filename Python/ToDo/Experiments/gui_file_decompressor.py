import PySimpleGUI as Sg
from zip_extractor import extract_archive

Sg.theme("Black")

label1 = Sg.Text("Select archive: ")
input1 = Sg.Input()
button1 = Sg.FileBrowse("Choose", key="Archive")

label2 = Sg.Text("Select destination: ")
input2 = Sg.Input()
button2 = Sg.FolderBrowse("Choose", key="Folder")

extract_button = Sg.Button("Extract")
output_label = Sg.Text(key="Output", text_color="green")

window = Sg.Window("Archive Extractor",
                   layout=[[label1, input1, button1],
                           [label2, input2, button2],
                           [extract_button, output_label]])

while True:
    event, values = window.read()
    match event:
        case "Extract":
            print(event,values)
            archivepath = values["Archive"]
            dest_dir = values["Folder"]
            extract_archive(archivepath, dest_dir)
            window["Output"].update(value="Extraction complete")
        case Sg.WINDOW_CLOSED:
            break

window.close()
