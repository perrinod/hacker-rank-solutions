#https://www.hackerrank.com/challenges/utopian-tree/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def utopianTree(n):
    size = 1

    if(n == 0):
        return size

    season = True

    while(n > 0):
        
        if(season):
            size *= 2
        else:
            size += 1

        season = not season
        n -= 1

    return size

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t = int(input())

    for t_itr in range(t):
        n = int(input())

        result = utopianTree(n)

        fptr.write(str(result) + '\n')

    fptr.close()
