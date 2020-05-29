# https://www.hackerrank.com/challenges/lonely-integer/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def lonelyinteger(a):
    value = 0

    for i in range(len(a)):
        value ^= a[i]

    return value

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    a = list(map(int, input().rstrip().split()))

    result = lonelyinteger(a)

    fptr.write(str(result) + '\n')

    fptr.close()