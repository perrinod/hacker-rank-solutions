#https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def minimumAbsoluteDifference(arr):
    minDiff = sys.maxsize
    arr.sort()
    
    for i in range(0, len(arr) - 1):
        diff = abs(arr[i] - arr[i+1])
        if(diff < minDiff):
            minDiff = diff

    return minDiff

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = minimumAbsoluteDifference(arr)

    fptr.write(str(result) + '\n')

    fptr.close()
