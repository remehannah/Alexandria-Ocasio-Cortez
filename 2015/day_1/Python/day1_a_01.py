from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))

class NotQuiteLisp:
    def __init__(self) -> None:
        self.instructions = {')': -1, '(': 1}
        self.current_floor = 0

    def get_current_floor(self, file_input):
        with open(file_input, 'r') as file:
            for line in file:
                for char in line:
                    self.current_floor += self.instructions[char]

        print(self.current_floor)
            



if __name__ == "__main__":
    my_solution = NotQuiteLisp()
    my_solution.get_current_floor(f"{dir_path}/input.txt")



