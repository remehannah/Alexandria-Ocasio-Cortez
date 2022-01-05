# from os import path

# dir_path = path.dirname(path.dirname(path.realpath(__file__)))
# f = open(f"{{dir_path}}/input.txt")
# lines = f.readlines()
import hashlib

class Solution:
    def __init__(self, key, n) -> None:
        self.hasher = hashlib.md5
        self.key = key
        self.n = n
    
    def create_md5_hash(self, secret_key):
        return self.hasher(secret_key.encode()).hexdigest()

    def find_answer(self):
        leading_zeros = '0' * self.n
        range_ = 0

        while self.create_md5_hash(f"{self.key}{range_}")[:self.n] != leading_zeros:
            range_ += 1
        
        return range_

if __name__ == "__main__":
    sol = Solution('iwrupvqb', 6)
    print(sol.find_answer())

# f.close()
