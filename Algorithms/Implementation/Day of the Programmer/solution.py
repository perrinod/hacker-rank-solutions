#https://www.hackerrank.com/challenges/day-of-the-programmer/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def dayOfProgrammer(year):
    if(year == 1918):
        return "26.09." + str(year)

    if(year < 1918):
        s = "12.09." if year % 4 == 0 else "13.09."
    else:
        s = "12.09." if (year % 400 == 0 or (year % 4 == 0 and year % 100 != 0)) else "13.09."

    return s + str(year)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    year = int(input().strip())

    result = dayOfProgrammer(year)

    fptr.write(result + '\n')

    fptr.close()
