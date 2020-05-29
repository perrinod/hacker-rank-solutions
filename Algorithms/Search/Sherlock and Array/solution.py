# https://www.hackerrank.com/challenges/sherlock-and-array/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def balancedSums(arr):
    count = sum(arr)

    if(count == arr[0]):
        return "YES"

    total = arr[0]

    for i in range(1, len(arr)):
        if(total == count - arr[i] - total or count - arr[i] == 0):
            return "YES"

        total += arr[i]

    return "NO"

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    T = int(input().strip())

    for T_itr in range(T):
        n = int(input().strip())

        arr = list(map(int, input().rstrip().split()))

        result = balancedSums(arr)

        fptr.write(result + '\n')

    fptr.close()