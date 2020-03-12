#https://www.hackerrank.com/challenges/picking-numbers/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def pickingNumbers(a):
    maximum = 0
    frequency = [0] * 100

    for i in range(0, len(a)):
        frequency[a[i]] += 1

    for i in range(2, len(frequency)):
        maximum = max(maximum,frequency[i] + frequency[i-1])
    
    return maximum

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    a = list(map(int, input().rstrip().split()))

    result = pickingNumbers(a)

    fptr.write(str(result) + '\n')

    fptr.close()