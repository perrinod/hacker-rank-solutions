//https://www.hackerrank.com/challenges/vector-erase/problem
#include <vector>
#include <iostream>


int main() {
    int size, input;
    std::vector<int> numbers;
    std::cin >> size;
    for(int i = 0; i < size; i++){
        std::cin >> input;
        numbers.push_back(input);
    }

    int erase;
    std::cin >> erase;

    numbers.erase(numbers.begin() + erase-1);

    int begin, end;
    std::cin >> begin >> end;
    numbers.erase(numbers.begin()+begin-1, numbers.begin()+end-1);


    std::cout << numbers.size() << std::endl;
    for(int& number : numbers){
        std::cout << number << " ";
    }

    return 0;
}