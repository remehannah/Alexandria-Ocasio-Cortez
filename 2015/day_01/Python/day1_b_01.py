from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))

class NotQuiteLisp:
    def __init__(self) -> None:
        self.instructions = {')': -1, '(': 1}
        self.current_floor = 0
        self.char_position = 0

    def find_basement(self, file_input):
        with open(file_input, 'r') as file:
            for line in file:
                for char in line:
                    self.current_floor += self.instructions[char]
                    self.char_position += 1
                    if self.current_floor == -1:
                        print(self.char_position)
                        return

        
            



if __name__ == "__main__":
    my_solution = NotQuiteLisp()
    my_solution.find_basement(f"{dir_path}/input.txt")



