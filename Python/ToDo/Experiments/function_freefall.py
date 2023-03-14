def calculate_time(h, g=9.80665):
    t = (2 * h / g) ** 0.5
    return t


height = int(input("Enter height for calculation: "))
time = calculate_time(height)
print(time)
