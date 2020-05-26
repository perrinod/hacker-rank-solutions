# https://www.hackerrank.com/challenges/3d-surface-area/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def surfaceArea(A):
    area = 0

    for i in range(len(A)):
        for j in range(len(A[i])):
            area += 4 * A[i][j] + 2

            if(i + 1 < len(A)):
                area -= 2 * min(A[i][j], A[i + 1][j])

            if(j + 1 < len(A[i])):
                area -= 2 * min(A[i][j], A[i][j + 1])

    return area

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    HW = input().split()

    H = int(HW[0])

    W = int(HW[1])

    A = []

    for _ in range(H):
        A.append(list(map(int, input().rstrip().split())))

    result = surfaceArea(A)

    fptr.write(str(result) + '\n')

    fptr.close()