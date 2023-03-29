import random

print("Random number generator")

lower = int(input("Enter lower bound for generator: "))
upper = int(input("Enter upper bound for generator: "))

print(random.randint(lower, upper))
