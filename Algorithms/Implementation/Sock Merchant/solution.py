#https://www.hackerrank.com/challenges/sock-merchant/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def sockMerchant(n, ar):
    dict = {}

    for i in range(0, len(ar)):
        if ar[i] in dict:
            dict[ar[i]] += 1
        else:
            dict[ar[i]] = 1

    pairs = 0
    for key in dict:
        pairs += (int)(dict[key] / 2)

    return pairs

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = sockMerchant(n, ar)

    fptr.write(str(result) + '\n')

    fptr.close()