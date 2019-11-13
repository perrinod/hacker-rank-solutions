#https://www.hackerrank.com/challenges/cut-the-sticks/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def cutTheSticks(arr):
    arr.sort()
    sticks = []
    sticks.append(len(arr))

    for i in range(0, len(arr) - 1):
        if(arr[i] != arr[i+1]):
            sticks.append(len(arr) - (i + 1))

    return sticks

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = cutTheSticks(arr)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()