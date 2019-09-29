#https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def divisibleSumPairs(n, k, ar):
    pair = 0

    for i in range(0, n):
        for j in range(i+1, n):
            value = ar[i] + ar[j]; 
            if((value % k) == 0):
                pair+= 1

    
    return pair

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    ar = list(map(int, input().rstrip().split()))

    result = divisibleSumPairs(n, k, ar)

    fptr.write(str(result) + '\n')

    fptr.close()
