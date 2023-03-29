import csv

with open("Files/weather.csv", 'r') as file:
    data = list(csv.reader(file))

print(data)
city = input("Enter a city: ")

for row in data[1:]:  # skips first row in csv file (not relevant station in this case)
    if row[0] == city:
        print(f"{row[1]}°C")

