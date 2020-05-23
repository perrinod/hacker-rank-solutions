# https://www.hackerrank.com/challenges/two-strings/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def twoStrings(s1, s2):
    s1 = "".join(set(s1))
    for i in range(0, len(s2)):
        if (s2[i] in s1):
            return "YES"
    
    return "NO"

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s1 = input()

        s2 = input()

        result = twoStrings(s1, s2)

        fptr.write(result + '\n')

    fptr.close()