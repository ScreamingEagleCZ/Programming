# Exercise 1 conversion of litres to cubics/square meters
litres = input("Enter litres for cubic conversion: ")


def convert_to_cubic(litres_loc):
    litres_loc = float(litres_loc)
    cubics_loc = litres_loc * 0.001
    return litres_loc, cubics_loc


cubics = convert_to_cubic(litres)
print(f"{cubics[0]} litres is equal to {cubics[1]} cubics/m3...")

# exercise 2 function for verification of password strength
password = input("Enter password for strength checker: ")


def check_pwd_strength(password_loc):
    result = {}
    if len(password_loc) >= 8:
        result["length"] = True
    else:
        result["length"] = False

    digit = False
    upper = False
    for i in password_loc:
        if i.isdigit():
            digit = True
        if i.isupper():
            upper = True
    result["digit"] = digit
    result["upper"] = upper

    if all(result.values()):  # if all elements in list are TRUE
        return "Pretty solid password... ;)"
    else:
        return "Weak password..."


print(check_pwd_strength(password))
