password = input("Enter password for strength checker: ")
result = {}

if len(password) >= 8:
    result["length"] = True
else:
    result["length"] = False

digit = False
for i in password:
    if i.isdigit():
        digit = True
result["digit"] = digit

upper = False
for i in password:
    if i.isupper():
        upper = True
result["upper"] = upper

print(result)

if all(result.values()):  # if all elements in list are TRUE
    print("Pretty solid password... ;)")
else:
    print("Weak password...")
