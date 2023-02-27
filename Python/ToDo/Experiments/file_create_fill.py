contents = ["Bmw´s are the best cars in the World",
            "5th Element is my favourite movie",  # splitting too long commands
            "Snowboarding"  # start of string - no "," used continues on next line
            " for life!"]  # splitting single string to multiple rows
filenames = ["cars.txt", "movies.txt", "sports.txt"]

# zip method merges together two lists 1st with 1st, 2nd with 2ns, etc.
for content, filename in zip(contents, filenames):
    file = open(f"../Files/Aux_files/{filename}", 'w')  # 2 dots means go up one directory first
    file.write(content)
    file.close()

single_long_string_splitting = "I am a single long string " \
                               "which is on multiple " \
                               "rows"
print(single_long_string_splitting)
