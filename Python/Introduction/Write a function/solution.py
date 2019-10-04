#https://www.hackerrank.com/challenges/write-a-function/problem
def is_leap(year):
    leap = False
    
    if (year % 4 == 0):
        if(year % 100 == 0):
            if(year % 400 == 0):
                return True;
            else:
                return False;
        else:
            return True;
    else:
        return False;
    
    return leap

year = int(input())
print(is_leap(year))