waiting_list = ["trevor", "lyiuda", "penelope", "Jebediah"]
for index, item in enumerate(waiting_list):
    print(f"{index + 1}) {item}")

print()

waiting_list.sort()  # ascending order sorting
for index, item in enumerate(waiting_list):  # enumerate numbers the list entities
    print(f"{index + 1}) {item.capitalize()}")

print()

waiting_list.sort(reverse=True)  # descending order sorting
for index, item in enumerate(waiting_list):
    print(f"{index + 1}) {item.capitalize()}")