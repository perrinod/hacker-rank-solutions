//https://www.hackerrank.com/challenges/variable-sized-arrays/problem
#include <vector>
#include <iostream>


int main() {  
    int arrays, queries, size, input, index, value;
    std::vector <std::vector<int>> multidim;

    std::cin >> arrays >> queries;
    
    multidim.resize(arrays);

    for(int i = 0; i < arrays; i++){
        std::cin >> size;
        multidim[i].resize(size);
        for (int j = 0; j < size; j++){
            std::cin >> input;            
            multidim[i][j] = input;
        }
    }

    for(int i = 0; i < queries; i++){
        std::cin >> index >> value;
        std::cout << multidim[index][value] << std::endl;
    }

    return 0;
}