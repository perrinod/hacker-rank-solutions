# https://www.hackerrank.com/challenges/grid-challenge/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def gridChallenge(grid):
    grid[0] = ''.join(sorted(grid[0]))

    for i in range(1,len(grid)):
        grid[i] = ''.join(sorted(grid[i]))

        for j in range(len(grid[i])):
            if(grid[i-1][j] > grid[i][j]):
                return "NO"
    
    return "YES"

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t = int(input())

    for t_itr in range(t):
        n = int(input())

        grid = []

        for _ in range(n):
            grid_item = input()
            grid.append(grid_item)

        result = gridChallenge(grid)

        fptr.write(result + '\n')

    fptr.close()
