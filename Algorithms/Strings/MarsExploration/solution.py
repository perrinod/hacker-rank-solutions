#https://www.hackerrank.com/challenges/mars-exploration/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def marsExploration(s):
    count, sos = 0, "SOS"

    for i in range(0, len(s)):
        if(s[i] != sos[i % 3]):
            count += 1

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = marsExploration(s)

    fptr.write(str(result) + '\n')

    fptr.close()