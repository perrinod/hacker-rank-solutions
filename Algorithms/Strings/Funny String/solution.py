#https://www.hackerrank.com/challenges/funny-string/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def funnyString(s):
    j = len(s) - 1
    for i in range(0, len(s) - 1):
        if(abs(ord(s[i]) - ord(s[i+1])) != abs(ord(s[j]) - ord(s[j-1]))):
            return "Not Funny"
        j -= 1

    return "Funny"

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = funnyString(s)

        fptr.write(result + '\n')

    fptr.close()