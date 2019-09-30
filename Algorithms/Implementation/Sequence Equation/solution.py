#https://www.hackerrank.com/challenges/permutation-equation/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def permutationEquation(p):
    value = 0
    q = [0] * len(p)

    for i in range(0, len(p)):
        value = i + 1

        value = p.index(value) + 1
        value = p.index(value) + 1
        q[i] = value

    return q

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    p = list(map(int, input().rstrip().split()))

    result = permutationEquation(p)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
