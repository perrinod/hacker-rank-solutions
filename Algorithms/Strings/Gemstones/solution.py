# https://www.hackerrank.com/challenges/gem-stones/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def gemstones(arr):
    rocks = {}

    for i in range (len(arr)):
        for j in range (len(arr[i])):
            if arr[i][j] not in rocks:
                rocks[arr[i][j]] = 0
            if rocks[arr[i][j]] == i:
                rocks[arr[i][j]]+= 1

    count = 0
    
    for key, gem in rocks.items():
        if(gem == len(arr)):
            count += 1

    return count


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = []

    for _ in range(n):
        arr_item = input()
        arr.append(arr_item)

    result = gemstones(arr)

    fptr.write(str(result) + '\n')

    fptr.close()