#https://www.hackerrank.com/challenges/sherlock-and-squares/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def squares(a, b):
    count = 0

    while(a <= b):

        if(math.sqrt(a) % 1.0 == 0):
            count+= 1
            a = a + math.floor(math.sqrt(a)) * 2 if a >= 16 else a + 1

        else:
            a+= 1
    
    return count;

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        ab = input().split()

        a = int(ab[0])

        b = int(ab[1])

        result = squares(a, b)

        fptr.write(str(result) + '\n')

    fptr.close()