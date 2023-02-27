file = open(r"C:\Users\Grand_Masta_Blasta\Downloads\testfile.txt", 'r')
text = file.readlines()
file.close()
for each in text:
    print(each)
