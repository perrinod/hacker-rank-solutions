#https://www.hackerrank.com/challenges/counting-valleys/problem
#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the countingValleys function below.
def countingValleys(n, s):
    valley = count = 0
    downhill = False

    for i in range(0, n):
        if(s[i] == 'U'):
            valley+= 1
        else:
            if(valley == 0):
                downhill = True

            valley-= 1
        
        if(valley == 0 and downhill):
            count+= 1
            downhill = False

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    s = input()

    result = countingValleys(n, s)

    fptr.write(str(result) + '\n')

    fptr.close()
