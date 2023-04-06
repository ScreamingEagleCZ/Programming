def parse(feet_inches_loc):
    parts = feet_inches_loc.split(' ')
    feet = float(parts[0])
    inches = float(parts[1])
    return {"feet": feet, "inches": inches}  # using dictionary


def convert(feet, inches):
    meters = feet * 0.3048 + inches * 0.0254
    return meters
