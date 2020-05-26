# https://www.hackerrank.com/challenges/maximizing-xor/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def maximizingXor(l, r):
    largest = 0

    for i in range(l,r+1):
        for j in range(l,r+1):
            largest = max(largest, i^j)

    return largest

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    l = int(input())

    r = int(input())

    result = maximizingXor(l, r)

    fptr.write(str(result) + '\n')

    fptr.close()
