#https://www.hackerrank.com/challenges/mark-and-toys/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def maximumToys(prices, k):
    count = 0
    prices.sort()
    
    for i in range(0, len(prices)):
        k -= prices[i]

        if(k > 0):
            count += 1
        else:
            return count

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    prices = list(map(int, input().rstrip().split()))

    result = maximumToys(prices, k)

    fptr.write(str(result) + '\n')

    fptr.close()