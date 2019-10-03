//https://www.hackerrank.com/challenges/c-tutorial-strings/problem
#include<iostream>
#include<string>
int main(){
    std::string a, b;
    char temp;

    std::cin >> a >> b;

    std::cout << a.size() << " " << b.size() << std::endl;
    std::cout << a + b << std::endl;
    
    temp = b[0];
    b[0] = a[0];
    a[0] = temp;

    std::cout << a << " " << b << std::endl;

    return 0;
}