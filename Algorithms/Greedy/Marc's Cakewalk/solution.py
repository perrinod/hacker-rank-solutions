#https://www.hackerrank.com/challenges/marcs-cakewalk/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def marcsCakewalk(calorie):
        count, i = 0, len(calorie) - 1
        calorie.sort()

    
        for n in range(0, len(calorie)):
            count += (calorie[i] * pow(2,n))
            i -= 1

        return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    calorie = list(map(int, input().rstrip().split()))

    result = marcsCakewalk(calorie)

    fptr.write(str(result) + '\n')

    fptr.close()
