# https://www.hackerrank.com/challenges/beautiful-binary-string/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def beautifulBinaryString(b):
    return int((len(b) - len(b.replace("010", ""))) / 3)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    b = input()

    result = beautifulBinaryString(b)

    fptr.write(str(result) + '\n')

    fptr.close()
