#https://www.hackerrank.com/challenges/flipping-bits/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def flippingBits(n):
    return pow(2,32) - 1 - n

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        n = int(input())

        result = flippingBits(n)

        fptr.write(str(result) + '\n')

    fptr.close()