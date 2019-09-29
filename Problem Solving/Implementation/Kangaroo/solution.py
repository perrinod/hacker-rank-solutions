#https://www.hackerrank.com/challenges/kangaroo/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def kangaroo(x1, v1, x2, v2):
    deltaX = x1 - x2
    deltaV = v2 - v1
    if deltaV == 0:
        intersect = 0
    else:
        intersect = deltaX / deltaV

    if((deltaX < 0 and deltaV > 0) or (deltaX > 0 and deltaV < 0) or intersect % 1.0 != 0 or intersect == 0):
        return "NO"

    return "YES"

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    x1V1X2V2 = input().split()

    x1 = int(x1V1X2V2[0])

    v1 = int(x1V1X2V2[1])

    x2 = int(x1V1X2V2[2])

    v2 = int(x1V1X2V2[3])

    result = kangaroo(x1, v1, x2, v2)

    fptr.write(result + '\n')

    fptr.close()