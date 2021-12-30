from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))



with open(f"{dir_path}/input.txt", 'r') as f:
    for line in f:
        for char in line:

