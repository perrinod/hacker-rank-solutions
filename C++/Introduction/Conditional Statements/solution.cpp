//https://www.hackerrank.com/challenges/c-tutorial-conditional-if-else/problem
#include <iostream>

int main() {
    std::string numbers[10] = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "Greater than 9"};
    int input;
    std::cin >> input;

    input <= 9 ? std::cout << numbers[input - 1] : std::cout << numbers[9];
 
   return 0;
}
