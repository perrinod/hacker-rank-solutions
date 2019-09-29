#https://www.hackerrank.com/challenges/insertionsort1/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def insertionSort1(n, arr):
    insertValue = arr[n - 1]
    j = n - 2

    while j >= 0:
        if insertValue < arr[j]:
            arr[j + 1] = arr[j]
        else:
            break
        print(*arr, sep = " ")
        j -= 1
    arr[j + 1] = insertValue
    print(*arr, sep = " ")

if __name__ == '__main__':
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    insertionSort1(n, arr)
