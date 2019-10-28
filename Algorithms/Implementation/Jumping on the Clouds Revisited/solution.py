#https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def jumpingOnClouds(c, k):
    energy = 100
    i = k

    while(True):

        if(i == len(c) or c[i] == 1):
           energy -= 2

        energy -= 1

        if(i == 0 or i == len(c)):
           break
        
        i += k
        
        if(i >= len(c)):
           i -= len(c)

    return energy
    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    c = list(map(int, input().rstrip().split()))

    result = jumpingOnClouds(c, k)

    fptr.write(str(result) + '\n')

    fptr.close()