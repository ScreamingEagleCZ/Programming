password = input("Please enter password for length verification: ")
if len(password) > 7:
    print("Length of password is enough...")
elif len(password) == 7:
    print("Password is OK but not too strong...")
else:
    print("Too short password...")
