#https://www.hackerrank.com/challenges/countingsort1/problem
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
    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = countingSort(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
