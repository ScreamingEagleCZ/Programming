temperatures = [10, 12, 14]
str_temperatures = [str(i) + '\n' for i in temperatures]
file = open("file.txt", 'w')
file.writelines(str_temperatures)
file.close()

numbers = [12.1, 14.3, 16.7]
numbers = [int(number) for number in numbers]
print(numbers)
