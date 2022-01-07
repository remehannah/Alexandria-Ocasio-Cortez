from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))
f = open(f"{{dir_path}}/input.txt")
lines = f.readlines()

class Solution:
    pass

if __name__ == "__main__":
    pass

f.close()
