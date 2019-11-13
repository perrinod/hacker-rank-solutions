#https://www.hackerrank.com/challenges/missing-numbers/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def missingNumbers(arr, brr):
    arr.sort()
    brr.sort()
    missing = set()

    i, j = 0, 0
    while(i < len(brr)):
        if(j >= len(arr) or arr[j] != brr[i]):
            missing.add(brr[i])
        else:
            j += 1
        
        i += 1

    return sorted(missing)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    m = int(input())

    brr = list(map(int, input().rstrip().split()))

    result = missingNumbers(arr, brr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()