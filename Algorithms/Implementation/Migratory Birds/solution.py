#https://www.hackerrank.com/challenges/migratory-birds/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def migratoryBirds(arr):
        birds = [0] * 5

        for i in range(0, len(arr)):
            birds[arr[i]-1] += 1

        highest = index = 0

        for i in range(0, len(birds)):
            if(highest < birds[i]):
                highest = birds[i]
                index = i + 1

        return index;

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    arr_count = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    result = migratoryBirds(arr)

    fptr.write(str(result) + '\n')

    fptr.close()