#https://www.hackerrank.com/challenges/countingsort2/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def countingSort(arr):
    count = [0] * 100
    for i in range(0,len(arr)):
        count[arr[i]]+= 1
    
    total = 0
    for i in range(0, len(count)):
        count[i], total = total, count[i] + total

    output = [0] * len(arr)

    for i in range(0, len(arr)):
        output[count[arr[i]]] = arr[i]
        count[arr[i]] += 1
    
    return output


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = countingSort(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()