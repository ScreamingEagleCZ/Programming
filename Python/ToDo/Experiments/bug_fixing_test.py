buttons = ["cancel", "reply", "submit"]

for i in buttons:
    print(i.capitalize())

for item in ["sandals", "glasses", "trousers"]:
    print(item.capitalize())

countries = []
while True:
    country = input("Enter the country: ")
    countries.append(country)
    print(countries)
