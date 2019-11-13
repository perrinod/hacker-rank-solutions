#https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def jumpingOnClouds(c):
    count, i = 0, 0

    while(i < len(c) - 1):
        count += 1
        i = i + 2 if i + 2 < len(c) and c[i + 2] == 0 else i + 1

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    c = list(map(int, input().rstrip().split()))

    result = jumpingOnClouds(c)

    fptr.write(str(result) + '\n')

    fptr.close()
