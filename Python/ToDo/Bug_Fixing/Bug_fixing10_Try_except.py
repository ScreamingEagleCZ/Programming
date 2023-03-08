try:
    waiting_list = ["john", "marry"]
    name = input("Enter name: ")

    number = waiting_list.index(name)
    print(f"{name}'s turn is {number}")
except ValueError:
    print(f"Sadly {name} is not on the list...")
    print(f"On the list are: {waiting_list}")
