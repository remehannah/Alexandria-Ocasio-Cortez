from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))

file = open(f"{dir_path}/input.txt").read()

current_floor = sum(map(lambda x: -1 if x == ')' else 1, file))

print(current_floor)