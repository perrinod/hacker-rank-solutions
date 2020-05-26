# https://www.hackerrank.com/challenges/equality-in-a-array/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def equalizeArray(arr):
    largest = 0
    frequency = [0] * 101

    for i in range(0, len(arr)):
        frequency[arr[i]] += 1
        if(largest < frequency[arr[i]]):
            largest = frequency[arr[i]]
    
    return len(arr) - largest

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = equalizeArray(arr)

    fptr.write(str(result) + '\n')

    fptr.close()