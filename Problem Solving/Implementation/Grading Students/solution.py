#https://www.hackerrank.com/challenges/grading/problem
#!/bin/python3

import math
import os
import random
import re
import sys

def gradingStudents(grades):
    for i in range(0, len(grades)):
        grade = abs(5 - grades[i] % 5)
        if(grade < 3 and grades[i] >= 38):
            grades[i] += grade
    return grades


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    grades_count = int(input().strip())

    grades = []

    for _ in range(grades_count):
        grades_item = int(input().strip())
        grades.append(grades_item)

    result = gradingStudents(grades)

    fptr.write('\n'.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
