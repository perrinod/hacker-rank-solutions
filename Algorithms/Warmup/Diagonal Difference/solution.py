#https://www.hackerrank.com/challenges/diagonal-difference/problem
#!/bin/python3

import math
import os
import random
import re
import sys


def diagonalDifference(arr):
    first = second = 0
    j = len(arr) - 1
    for i in range(0, len(arr)):
        first += arr[i][i]
        second += arr[j][i]
        j -= 1
    
    return abs(first - second)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    arr = []

    for _ in range(n):
        arr.append(list(map(int, input().rstrip().split())))

    result = diagonalDifference(arr)

    fptr.write(str(result) + '\n')

    fptr.close()