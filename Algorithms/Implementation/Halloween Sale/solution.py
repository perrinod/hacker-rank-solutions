#https://www.hackerrank.com/challenges/halloween-sale/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def howManyGames(p, d, m, s):
    count = 0

    while(s >= p):
        s -= p
        p = max(p - d, m)
        count += 1

    return count;

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    pdms = input().split()

    p = int(pdms[0])

    d = int(pdms[1])

    m = int(pdms[2])

    s = int(pdms[3])

    answer = howManyGames(p, d, m, s)

    fptr.write(str(answer) + '\n')

    fptr.close()