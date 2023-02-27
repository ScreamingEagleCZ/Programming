# print out content of file with each word in uppercase
file = open(r"C:\Users\Grand_Masta_Blasta\Downloads\essay.txt", 'r')
text = file.read()
file.close()
print(text.title())

# reads out file and outputs number of characters
file = open(r"C:\Users\Grand_Masta_Blasta\Downloads\essay.txt", "r")
text = file.read()
file.close()
print(len(text))

# Upon each run of program add text to file
file = open(r"C:\Users\Grand_Masta_Blasta\Downloads\members.txt", 'r')
text = file.readlines()
file.close()
user = input("Please add name to members: ")
text.append(user + "\n")
file = open(r"C:\Users\Grand_Masta_Blasta\Downloads\members.txt", 'w')
file.writelines(text)
file.close()
print(text)

# generate files with word "Hello" in each file
filenames = ["file1.txt", "file2.txt"]
for each in filenames:
    file = open(fr"Aux_Files\{each}", 'w')
    file.write("Hello from exercise 6... :)")
    file.close()

# Read and print from 3 files on separate lines
files = ["a.txt", "b.txt", "c.txt"]
for each in files:
    file = open(rf"C:\Users\Grand_Masta_Blasta\Downloads\{each}", 'r')
    text = file.read()
    file.close()
    print(text)