user_country = input("Enter Your Country: ")
match user_country:
    case 'USA':
        print("Hello")
    case 'India':
        print("Namaste")
    case 'Grmany':
        print('Hallo')

ingredients = ["john smith", "sen plakay", "dora ngacely"]
for each in ingredients:
    print(each.title())
