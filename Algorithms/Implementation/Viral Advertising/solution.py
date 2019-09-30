#https://www.hackerrank.com/challenges/strange-advertising/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def viralAdvertising(n):
    total, floor = 0, 5
    
    for i in range(0, n):
        total += int(floor / 2)
        floor = int(floor / 2) * 3
    
    return total

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    result = viralAdvertising(n)

    fptr.write(str(result) + '\n')

    fptr.close()