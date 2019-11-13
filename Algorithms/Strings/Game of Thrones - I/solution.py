#https://www.hackerrank.com/challenges/game-of-thrones/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def gameOfThrones(s):
    s = ''.join(sorted(s))

    palindrome = True if len(s) % 2 == 0 else False

    i = 0
    for j in range(0, len(s)):
        if(s[i] != s[j]):
            if((j - i) % 2 != 0):
                if(palindrome):
                    return "NO"
                palindrome = True
            
            i = j

    return "YES"

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = gameOfThrones(s)

    fptr.write(result + '\n')

    fptr.close()