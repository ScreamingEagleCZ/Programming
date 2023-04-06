# Dollar to Euro Conversion
dollars = int(input("Please enter how many dollars to convert: "))
print("You would get " + str(dollars * 0.95) + " Euros...")

# Drivers ranking
ranking = ["Ken Block", "Travis Pastrana", "Colin McRae"]
position = int(input("Which place do U want to know?: "))
print(ranking[position - 1])

# Search in above list (ranking) by name
name = input("Enter driver´s name to show position: ")
print(ranking.index(name) + 1)
