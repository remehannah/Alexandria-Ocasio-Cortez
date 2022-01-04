#!/usr/bin/env python

import os
import sys
from time import sleep

# get_valid_input
input_parsed = sys.argv

if len(input_parsed) != 2 or ' ' in input_parsed:
    print("Invalid input")
    sys.exit()

dotnet_file_name = input_parsed[1]

create_project_command = f"mkdir {dotnet_file_name} && cd {dotnet_file_name} && dotnet new console"
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
os.remove(f'{dotnet_file_name}/Program.cs')
new_cs_file = open(f'{dotnet_file_name}/Program.cs','w+')
new_cs_file.write(class_description)
new_cs_file.close()

new_git_ignore = open(f'{dotnet_file_name}/.gitingore', 'w+')
new_git_ignore.write(git_ignore)
new_cs_file.close

print("project complete")
