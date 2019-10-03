//https://www.hackerrank.com/challenges/cpp-lower-bound/problem
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

    std::cin >> size;

    for(int i = 0; i < size; i++){
        std::cin >> input;
        std::vector<int>::iterator it = std::lower_bound(numbers.begin(), numbers.end(), input);

        if(numbers[it - numbers.begin()] == input)
            std::cout << "Yes ";
        else
            std::cout << "No ";
            
        std::cout << (it - numbers.begin() + 1) << std::endl;
    }
     
    return 0;
}