feet_inches = input("Enter feet and inches: ")

# it's better to split functions to smaller separate functions


def parse(feet_inches_loc):
    parts = feet_inches_loc.split(' ')
    feet = float(parts[0])
    inches = float(parts[1])
    return {"feet": feet, "inches": inches}  # using dictionary


def convert(feet, inches):
    meters = feet * 0.3048 + inches * 0.0254
    return meters


parsed = parse(feet_inches)
result = convert(parsed['feet'], parsed['inches'])

print(f"{parsed['feet']} feet and {parsed['inches']} inches is equal to {result} meters.")

if result < 1:
    print("Sorry, You are too small for this...")
else:
    print("Feel free to continue!")
