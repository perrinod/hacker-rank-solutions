#https://www.hackerrank.com/challenges/insertionsort2/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def insertionSort2(n, arr):
    i = 1
    while (i < n):
        j = i
        while(j > 0 and arr[j-1] > arr[j]):
            arr[j], arr[j-1] = arr[j-1], arr[j]
            j-= 1
        i+= 1
        print(*arr, sep = " ")

if __name__ == '__main__':
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    insertionSort2(n, arr)