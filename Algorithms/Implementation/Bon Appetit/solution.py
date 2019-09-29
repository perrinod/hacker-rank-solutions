#https://www.hackerrank.com/challenges/bon-appetit/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def bonAppetit(bill, k, b):
    total = (sum(bill) - bill[k]) / 2
    output = "Bon Appetit" if (total == b) else int(b - total)

    print(output)

if __name__ == '__main__':
    nk = input().rstrip().split()

    n = int(nk[0])

    k = int(nk[1])

    bill = list(map(int, input().rstrip().split()))

    b = int(input().strip())

    bonAppetit(bill, k, b)
