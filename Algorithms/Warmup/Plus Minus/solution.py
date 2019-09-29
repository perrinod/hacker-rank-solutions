#https://www.hackerrank.com/challenges/plus-minus/problem
#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the plusMinus function below.
def plusMinus(arr):
    positive = negative = zero = 0.0

    for i in range(0, len(arr)):
        if arr[i] > 0 : positive += 1
        elif arr[i] < 0 : negative += 1
        else : zero += 1

    print(positive / len(arr), '\n' , negative / len(arr), '\n', zero / len(arr))

if __name__ == '__main__':
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    plusMinus(arr)