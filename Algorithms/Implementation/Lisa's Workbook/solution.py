#https://www.hackerrank.com/challenges/lisa-workbook/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def workbook(n, k, arr):
    count, page = 0, 1

    for problems in range(0, len(arr)):
        for i in range (1, arr[problems] + 1):
            if(i == page):
                count += 1
            if(i % k == 0):
                page += 1

        if(arr[problems] % k != 0):
            page += 1

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    arr = list(map(int, input().rstrip().split()))

    result = workbook(n, k, arr)

    fptr.write(str(result) + '\n')

    fptr.close()