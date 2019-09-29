#https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def breakingRecords(scores):
    highest = lowest = scores[0]
    highTotal = lowTotal = 0
    for i in range(0, len(scores)):
        if(highest < scores[i]):
            highest = scores[i]
            highTotal+= 1
        
        if(lowest > scores[i]):
            lowest = scores[i]
            lowTotal+=1
            
    return [highTotal, lowTotal]

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    scores = list(map(int, input().rstrip().split()))

    result = breakingRecords(scores)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
