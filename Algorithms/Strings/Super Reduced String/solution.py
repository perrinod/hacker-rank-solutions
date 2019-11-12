#https://www.hackerrank.com/challenges/reduced-string/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def superReducedString(s):
    i = 0
    while(i < len(s) - 1):
        if(s[i] == s[i+1]):
            s = s[:i] + s[i+2:]
            if(i != 0):
                i -= 1
        else:
            i += 1

    if(len(s) == 0):
        s = "Empty String"

    return s

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = superReducedString(s)

    fptr.write(result + '\n')

    fptr.close()