#https://www.hackerrank.com/challenges/chocolate-feast/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def chocolateFeast(n, c, m):
    chocolate = math.floor(n / c)
    wrappers = chocolate

    while(wrappers >= m):
        extra = math.floor(wrappers / m)
        chocolate += extra
        wrappers = extra + wrappers % m

    return chocolate

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t = int(input())

    for t_itr in range(t):
        ncm = input().split()

        n = int(ncm[0])

        c = int(ncm[1])

        m = int(ncm[2])

        result = chocolateFeast(n, c, m)

        fptr.write(str(result) + '\n')

    fptr.close()
