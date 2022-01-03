from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))

symbols = open(f"{dir_path}/input.txt").read()

floor_ = 0

def floorer(val):
    global floor_
    if val == '(':
        floor_ += 1
    else:
        floor_ -= 1
    return floor_

position = list(map(floorer, symbols)).index(-1) + 1

print(f"Santa reached the basement after {position} steps")

