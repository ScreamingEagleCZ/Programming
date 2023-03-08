def get_max_min():
    grades = [9.6, 9.2, 9.7]
    return max(grades), min(grades)


max_min = get_max_min()
print(f"Max: {max_min[0]}, Min: {max_min[1]}")
