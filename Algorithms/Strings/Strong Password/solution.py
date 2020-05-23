# https://www.hackerrank.com/challenges/strong-password/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def minimumNumber(n, password):
    count = 0
    if not re.search(".*[a-z].*" , password):
        count += 1
    if not re.search(".*[A-Z].*", password):
        count += 1
    if not re.search(".*[0-9].*", password):
        count += 1
    if re.search("^[a-zA-Z0-9]*$", password):
        count += 1
    
    return max(count, 6 - n)
    

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    password = input()

    answer = minimumNumber(n, password)

    fptr.write(str(answer) + '\n')

    fptr.close()