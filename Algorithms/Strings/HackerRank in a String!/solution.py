#https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def hackerrankInString(s):
    hackerRank = "hackerrank"
    if(len(s) < len(hackerRank)):
        return "NO"

    i = 0
    for c in s:
        if(hackerRank[i] == c):
            i+= 1
        
        if(i == len(hackerRank)):
            return "YES"


    return "NO"


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = hackerrankInString(s)

        fptr.write(result + '\n')

    fptr.close()
