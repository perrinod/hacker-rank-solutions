#https://www.hackerrank.com/challenges/find-digits/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def findDigits(n):
    digit = count = 0

    s = str(n);

    for i in range(0, len(s)):
        digit = int(s[i])

        if(digit != 0 and n % digit == 0):
            count+= 1

    return count;

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t = int(input())

    for t_itr in range(t):
        n = int(input())

        result = findDigits(n)

        fptr.write(str(result) + '\n')

    fptr.close()
