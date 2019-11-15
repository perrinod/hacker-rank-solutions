#https://www.hackerrank.com/challenges/anagram/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def anagram(s):
    if(len(s) % 2 != 0):
        return -1
    
    s1 = s[:math.floor(len(s) / 2)]
    s2 = s[math.floor(len(s) / 2):]

    count = 0

    for i in range(0, len(s1)):
        found = s2.find(s1[i])
        if(found != -1):
            s2 = s2[:found] + s2[found+1:]
        else:
            count += 1

    return count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = anagram(s)

        fptr.write(str(result) + '\n')

    fptr.close()