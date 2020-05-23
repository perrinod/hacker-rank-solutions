# https://www.hackerrank.com/challenges/caesar-cipher-1/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def caesarCipher(s, k):
    encryptedString = ""

    for i in range (0, len(s)):
        if(s[i].isalpha()):
            a = 'A' if s[i].isupper() else 'a'
            encryptedString += chr(ord(a) + (ord(s[i]) - ord(a) + k) % 26)
        else:
            encryptedString += s[i]

    return encryptedString

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    s = input()

    k = int(input())

    result = caesarCipher(s, k)

    fptr.write(result + '\n')

    fptr.close()