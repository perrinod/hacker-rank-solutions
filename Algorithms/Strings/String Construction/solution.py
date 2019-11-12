#https://www.hackerrank.com/challenges/string-construction/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def stringConstruction(s):
    characters = set()
    
    for i in range(0, len(s)):
        characters.add(s[i])

    return len(characters)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = stringConstruction(s)

        fptr.write(str(result) + '\n')

    fptr.close()