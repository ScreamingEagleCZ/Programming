feet_inches = input("Enter feet and inches: ")


def convert(feet_inches_loc):
    parts = feet_inches_loc.split(' ')
    feet = float(parts[0])
    inches = float(parts[1])

    meters = feet * 0.3048 + inches * 0.0254
    return feet, inches, meters


result = convert(feet_inches)
print(f"{result[0]} feet and {result[1]} inches is equal to {result[2]} meters.")

if result[2] < 1:
    print("Sorry, You are too small for this...")
else:
    print("Feel free to continue!")
