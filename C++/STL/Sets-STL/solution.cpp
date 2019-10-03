//https://www.hackerrank.com/challenges/cpp-sets/problem
#include <iostream>
#include <set>


int main() {
    int size, x, y;
    std::cin >> size;
    std::set<int> numbers;

    for(int i = 0; i < size; i++)  {
        std::cin >> x >> y;

        if(x == 1)
            numbers.insert(y);
        else if(x == 2)
            numbers.erase(y);
        else{
            std::set<int>::iterator iter = numbers.find(y);
            if(iter != numbers.end())
                std::cout << "Yes" << std::endl;
            else
                std::cout << "No" << std::endl;
                
        }
    }
    return 0;
}
