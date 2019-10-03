//https://www.hackerrank.com/challenges/vector-sort/problem
#include <algorithm>
#include <vector>
#include <iostream>


int main() {
    int size, input;
    std::cin >> size;
    std::vector<int> numbers;


    for(int i = 0; i < size; i++){
        std::cin >> input;
        numbers.push_back(input);
    }

    std::sort(numbers.begin(), numbers.end());

    for(int& number : numbers)
        std::cout << number << " ";
    std::cout << std::endl;


    return 0;
}