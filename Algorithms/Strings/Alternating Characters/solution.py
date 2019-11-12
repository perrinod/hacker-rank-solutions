#https://www.hackerrank.com/challenges/alternating-characters/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def alternatingCharacters(s):
    i, count = 0, 0
    
    for j in range(1, len(s)):
        if(s[i] == s[j]):
            count += 1
        else:
            i = j

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = alternatingCharacters(s)

        fptr.write(str(result) + '\n')

    fptr.close()
