try:
    width = float(input("Enter width of rectangle: "))
    length = float(input("Enter length of rectangle: "))
    if width == length:
        # exit message if needed...
        exit(f"That looks like a square...area ={width * length}...")
    area = width * length
    print(f"Area of rectangle is {area}...")
except ValueError:
    print("Please enter a number...")
