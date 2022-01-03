from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))

file = open(f"{dir_path}/input.txt").read()
symbols = iter(input())

steps_taken = 0
current_floor = 0

while current_floor!= -1:
    current_floor += -1 if next(symbols) == ')' else 1
    steps_taken += 1

print(f"Santa reached the basement after {steps_taken} steps")
