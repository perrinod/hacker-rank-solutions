//https://www.hackerrank.com/challenges/cpp-maps/problem
#include <iostream>
#include <map>
#include <string>

int main() {
    int size, q, y;
    std::string x;
    std::cin >> size;
    std::map<std::string,int> students;

    for(int i = 0; i < size; i++){
        std::cin >> q >> x;
        if(q == 1){
            std::cin >> y;
            students[x] += y;
        }
        else if(q == 2){
            students.erase(x);
        }
        else{
            std::map<std::string,int>::iterator iter = students.find(x);
            if(iter != students.end())
                std::cout << iter->second << std::endl;
            else
                std::cout << "0" << std::endl;
        }

    }   

    return 0;
}

