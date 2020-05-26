# https://www.hackerrank.com/challenges/priyanka-and-toys/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def toys(w):
    w.sort()
    containers = 1
    minimum = w[0]

    for i in range(len(w)):
        if(w[i] > minimum + 4):
            containers += 1
            minimum = w[i]

    return containers

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    w = list(map(int, input().rstrip().split()))

    result = toys(w)

    fptr.write(str(result) + '\n')

    fptr.close()