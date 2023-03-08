try:
    value = float(input("Enter a value: "))
    total = float(input("Enter a total value: "))
    percentage = value / total * 100

    print(f"That is {percentage}%")
except ValueError:
    print("You have to enter a number, run the program again...")
except ZeroDivisionError:
    print("Yeah...Zero total value...try that again ;)")
