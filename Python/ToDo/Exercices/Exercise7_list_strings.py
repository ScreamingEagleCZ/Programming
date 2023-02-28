names = ["john smith", "jay santi", "eva kuki"]
names = [i.title() for i in names]
print(names)

usernames = ["john 1990", "alberta1970", "magnola2000"]
length = [len(i) for i in usernames]
print(length)

user_entries = ['10', '19.1', '20']
float_user_entries = [float(i) for i in user_entries]
print(float_user_entries)

user_entries = ['20', '25.3', '40']
float_user_entries = [float(i) for i in user_entries]
print(sum(float_user_entries))
