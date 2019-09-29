#https://www.hackerrank.com/challenges/mini-max-sum/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def miniMaxSum(arr):
    mini, maxi, total = arr[0], arr[0], 0
    for i in range(0, len(arr)) :
        total += arr[i]
        if(arr[i] < mini):
            mini = arr[i]
        if(arr[i] > maxi):
            maxi = arr[i]

    print(total - maxi, total - mini)

if __name__ == '__main__':
    arr = list(map(int, input().rstrip().split()))

    miniMaxSum(arr)