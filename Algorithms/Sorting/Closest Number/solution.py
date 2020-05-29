# https://www.hackerrank.com/challenges/closest-numbers/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def closestNumbers(arr):
    arr.sort()
    minimum = sys.maxsize
    closest = []

    for i in range(1, len(arr)):
        if(arr[i] - arr[i-1] < minimum):
            closest.clear()
            
        if(arr[i] - arr[i-1] <= minimum):
            minimum = arr[i] - arr[i-1]
            closest.append(arr[i-1])
            closest.append(arr[i])

    return closest;

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = closestNumbers(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
