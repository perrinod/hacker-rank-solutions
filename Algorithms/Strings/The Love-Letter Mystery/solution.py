#https://www.hackerrank.com/challenges/the-love-letter-mystery/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def theLoveLetterMystery(s):
    i, count = len(s) - 1, 0

    for j in range(0, int(len(s) / 2)):
        count += abs(ord(s[j]) - ord(s[i]))
        i -= 1

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = theLoveLetterMystery(s)

        fptr.write(str(result) + '\n')

    fptr.close()