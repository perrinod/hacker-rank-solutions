# https://www.hackerrank.com/challenges/cavity-map/problem
#!/bin/python3

import math
import os
import random
import re
import sys


def cavityMap(grid):
    for i in range(1, len(grid) - 1):
        for j in range(1, len(grid[i]) - 1):
            number = grid[i][j]
            if(number > grid[i+1][j] and number > grid[i-1][j] and number > grid[i][j+1] and number > grid[i][j-1]):
                grid[i] = grid[i][0:j] + 'X' + grid[i][j+1:len(grid)]

    return grid

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    grid = []

    for _ in range(n):
        grid_item = input()
        grid.append(grid_item)

    result = cavityMap(grid)

    fptr.write('\n'.join(result))
    fptr.write('\n')

    fptr.close()