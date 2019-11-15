#https://www.hackerrank.com/challenges/making-anagrams/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def makingAnagrams(s1, s2):
    count = 0

    for i in range(0, len(s1)):
            found = s2.find(s1[i])
            if(found != -1):
                s2 = s2[:found] + s2[found+1:]
                count += 1

    return len(s1) - count + len(s2)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s1 = input()

    s2 = input()

    result = makingAnagrams(s1, s2)

    fptr.write(str(result) + '\n')

    fptr.close()
