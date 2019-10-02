//https://www.hackerrank.com/challenges/c-tutorial-for-loop/problem
#include<iostream>

int main() {
    int a, b;
    std::string numbers[10] = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

    std::cin >> a >> b;

    for(int i = a; i <= b; i++){
        if(i > 9 && (i % 2) == 0)
            std::cout << "even" << std::endl;
        else if (i > 9 && (i % 2) != 0)
            std::cout << "odd" << std::endl;
        else
            std::cout << numbers[i - 1] << std::endl;
    }

    return 0;
}
