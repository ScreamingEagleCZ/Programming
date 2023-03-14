def parse(names):
    return len(names.split(','))


def age_count(year_of_birth, current_year=2022):
    return current_year - year_of_birth


birth_year = int(input("Please enter Your birth year: "))
age = age_count(birth_year)
if age > 120:
    print(f"You look pretty good for your age...{age} years... ;) ")
else:
    print(f"Your age is {age} years")

names = input("Enter list of names separated by ',': ")
nr_names = parse(names)
print(f"You entered {nr_names} names...")
