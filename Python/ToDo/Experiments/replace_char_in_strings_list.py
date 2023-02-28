filenames = ["1.Raw.txt", "2.Modded.txt", "3.Finished.txt"]
print(filenames)

i = 0
for filename in filenames:
    filenames[i] = filename.replace('.', ') ', 1)  # num 1 means first occurrence only
    i = i + 1
print(filenames)
