date = input("Enter today´s date: ")
mood = input("Rate Your mood from 1 to 10: ")
journal = input("Write something about this day: \n")

with open(f"{date}.txt", 'w') as file:
    file.write(f"Date: {date}\n\n")
    file.write(f"Your mood rating is: {mood}\n\n")
    file.write(f"Day description:\n{journal}\n")
