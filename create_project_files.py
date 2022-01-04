# I just added an alias to my shell
# alias initproject='python /home/jaleelvs/Desktop/AOC/create_project_files.py'

import os
import sys
from time import sleep

# get_valid_input
input_parsed = sys.argv

if len(input_parsed) != 3 or ' ' in input_parsed:
    print("Invalid input")
    sys.exit()


day = input_parsed[1]
dotnet_file_name = input_parsed[2]

# create dirs
create_new_directories = f"mkdir day_{day} && cd day_{day} && mkdir C# && mkdir Python"
os.system(create_new_directories)



# cSharp
create_project_command = f"cd day_{day} && cd C# && mkdir {dotnet_file_name} && cd {dotnet_file_name} && dotnet new console"
os.system(create_project_command)

sleep(3)
print("Project initiated")
# add class template to Program.cs

class_description = f"""class {dotnet_file_name}
{{
    static void Main()
    {{
        Console.WriteLine("It's a new day");
    }}
}}
"""

git_ignore = f""".idea/
bin/
obj/
{dotnet_file_name}.csproj
"""
os.remove(f'day_{day}/C#/{dotnet_file_name}/Program.cs')
new_cs_file = open(f'day_{day}/C#/{dotnet_file_name}/Program.cs','w+')
new_cs_file.write(class_description)
new_cs_file.close()

new_git_ignore = open(f'day_{day}/C#/{dotnet_file_name}/.gitingore', 'w+')
new_git_ignore.write(git_ignore)
new_cs_file.close

# Python

py_template = """from os import path

dir_path = path.dirname(path.dirname(path.realpath(__file__)))
f = open(f"{{dir_path}}/input.txt")
lines = f.readlines()

class Solution:
    pass

if __name__ == "__main__":
    pass

f.close()
"""
new_py_file = open(f'day_{day}/Python/day_{day}_a.py', 'w+')
new_py_file.write(py_template)
new_py_file.close()
new_py_file = open(f'day_{day}/Python/day_{day}_b.py', 'w+')
new_py_file.write(py_template)
new_py_file.close()

print("All files created")

