# https://www.hackerrank.com/challenges/fair-rations/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def fairRations(B):
    total = sum(B)
    
    if(total % 2 != 0):
        return -1

    count = 0

    for i in range(1, len(B)):
        if(B[i-1] % 2 != 0):
            count += 2
            B[i] += 1

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    N = int(input())

    B = list(map(int, input().rstrip().split()))

    result = fairRations(B)

    if(result == -1):
        fptr.write("NO" + '\n')
    else:
        fptr.write(str(result) + '\n')

    fptr.close()
