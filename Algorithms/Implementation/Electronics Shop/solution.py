#https://www.hackerrank.com/challenges/electronics-shop/problem
#!/bin/python3

import os
import sys

def getMoneySpent(keyboards, drives, b):
    maximum = 0

    for i in range(0, len(keyboards)):
        for j in range(0, len(drives)):
            amount = keyboards[i] + drives[j]
            if(amount <= b and amount > maximum):
                maximum = amount

    return -1 if maximum == 0 else maximum


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    bnm = input().split()

    b = int(bnm[0])

    n = int(bnm[1])

    m = int(bnm[2])

    keyboards = list(map(int, input().rstrip().split()))

    drives = list(map(int, input().rstrip().split()))

    #
    # The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
    #

    moneySpent = getMoneySpent(keyboards, drives, b)

    fptr.write(str(moneySpent) + '\n')

    fptr.close()