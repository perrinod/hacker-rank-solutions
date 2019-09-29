#https://www.hackerrank.com/challenges/drawing-book/problem
#!/bin/python3

import os
import sys

def pageCount(n, p):
    if(n == p or p == 1):
        return 0

    if(n % 2 == 0):
        n = n + 1

    back = int((n - p) / 2)
    front = int(p / 2)
    
    if (front > back):
        return back

    return front

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    p = int(input())

    result = pageCount(n, p)

    fptr.write(str(result) + '\n')

    fptr.close()