while True:
    with open("../Exercices/Aux_Files/coin_toss.txt", 'r') as file:
        history = file.readlines()

    toss = input("Throw coin and enter what dropped (tail/head): ") + '\n'
    history.append(toss)

    with open("../Exercices/Aux_Files/coin_toss.txt", 'w')as file:
        file.writelines(history)

    heads = history.count('head\n')
    tails = history.count('tail\n')
    total = heads + tails
    heads_percentage = float(100 * heads / total)
    tails_percentage = float(100 * tails / total)
    print(f"Heads: {heads_percentage}%")
    print(f"Tails: {tails_percentage}%")
