# https://www.hackerrank.com/challenges/circular-array-rotation/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def circularArrayRotation(a, k, queries):
    values = []

    for i in range(len(queries)):
        index = (len(a) - (k % len(a)) + queries[i]) % len(a)
        values.append(a[index])

    return values

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nkq = input().split()

    n = int(nkq[0])

    k = int(nkq[1])

    q = int(nkq[2])

    a = list(map(int, input().rstrip().split()))

    queries = []

    for _ in range(q):
        queries_item = int(input())
        queries.append(queries_item)

    result = circularArrayRotation(a, k, queries)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()