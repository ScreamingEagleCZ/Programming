from Exercices.Exercise14_functions import parse, convert

feet_inches = input("Enter feet and inches: ")

# it's better to split functions to smaller separate functions


parsed = parse(feet_inches)
result = convert(parsed['feet'], parsed['inches'])

print(f"{parsed['feet']} feet and {parsed['inches']} inches is equal to {result} meters.")

if result < 1:
    print("Sorry, You are too small for this...")
else:
    print("Feel free to continue!")
