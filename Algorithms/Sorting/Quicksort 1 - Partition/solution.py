# https://www.hackerrank.com/challenges/quicksort1/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def quickSort(arr):
    pivot = arr[0]
    left = [] 
    right = []
    equal = []

    for i in range(len(arr)):
        if(arr[i] < pivot):
            left.append(arr[i])
        elif(arr[i] == pivot):
            equal.append(arr[i])
        else:
            right.append(arr[i])

    return left + equal + right
    

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = quickSort(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
