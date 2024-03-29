import PySimpleGUI as Sg

Sg.theme("Black")


def convert(feet, inches):
    meters = feet * 0.3048 + inches * 0.0254
    return meters


label_feet = Sg.Text("Enter feet: ")
label_inches = Sg.Text("Enter inches: ")
input_feet = Sg.Input()
input_inches = Sg.Input()
button = Sg.Button("Convert", key="convert")
button_exit = Sg.Button("Exit")
output_label = Sg.Text("", key="meters")

window = Sg.Window("Feet & Inches to meters converter",
                   [[label_feet, input_feet],
                    [label_inches, input_inches],
                    [button, button_exit, output_label]])


while True:
    event, values = window.read()
    print(event)
    match event:
        case "convert":
            try:
                print(values)
                result = convert(float(values[0]), float(values[1]))
                output_label.update(f"{result} m")
            except ValueError:
                Sg.Popup("You are supposed to enter 2 numbers")
        case "Exit":
            break
        case Sg.WIN_CLOSED:
            break

window.close()
