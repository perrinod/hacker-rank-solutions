// https://www.hackerrank.com/challenges/playing-with-characters/problem
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() 
{
    char ch;
    scanf("%c", &ch);
    printf("%c\n", ch);

    char s[100];
    scanf("%s", &s);
    printf("%s\n", s);

    scanf(" %[^\n]%*c", &s);
    printf("%s\n", s);

    return 0;
}