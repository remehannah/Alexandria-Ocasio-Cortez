from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))
f = open(f"{dir_path}/input.txt")
lines = f.readlines()

class Solution:
    @staticmethod
    def calculate_area(x, y, z):
        return x * y + sum([2* x * y, 2 * x * z, 2 * z * y])
    
    @staticmethod 
    def calculate_length(x, y, z):
        return (2 * x + 2 * y) + (x * y * z)    

    def total_area_1(self):
        total_area = 0
        for line in lines:
            x, y, z = sorted(map(int, line.split('x')))
            total_area += self.calculate_area(x, y, z)

        return total_area

    def total_area_2(self):
        dims = [sorted(map(int, line.split('x'))) for line in lines]
        return sum(map(lambda x: 3 * x[0] * x[1] + 2 * x[0] * x[2] + 2 * x[1] * x[2], dims))

    def total_ribbon_length_1(self):
        total_length = 0
        for line in lines:
            x, y, z = sorted(map(int, line.split('x')))
            total_length += self.calculate_length(x, y, z)

        return total_length

    def total_ribbon_length_2(self):
        dims = [sorted(map(int, line.split('x'))) for line in lines]
        return sum(map(lambda x: 2 * x[0] + 2 * x[1] + x[0] * x[1] * x[2], dims))



if __name__ == "__main__":
    sol = Solution()
    print(sol.total_area_1())
    print(sol.total_area_2())
    print(sol.total_ribbon_length_1())
    print(sol.total_ribbon_length_2())
    

f.close()