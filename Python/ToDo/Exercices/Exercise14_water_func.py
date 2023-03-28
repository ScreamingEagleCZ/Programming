def state(temp):
    ice = 0
    gas = 100
    if temp >= gas:
        return "Gas"
    elif temp >= ice:
        return "Liquid"
    elif temp < ice:
        return "Solid Ice"
