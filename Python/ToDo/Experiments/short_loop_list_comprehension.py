filenames = ["1.doc", "1.report", "1.presentation"]
filenames = [filename.replace('.', '-') + '.txt' for filename in filenames]
print(filenames)

# list comprehension in comparison to standard for loop...same outputs from lines bellow
new = []
for i in [1, 2, 3]:
    new.append(i + 10)
print(new)

old2 = [1, 2, 3]
new2 = [i + 10 for i in old2]
print(new2)
