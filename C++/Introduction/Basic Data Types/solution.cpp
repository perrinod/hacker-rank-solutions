//https://www.hackerrank.com/challenges/c-tutorial-basic-data-types/problem
#include <iostream>
#include <iomanip>

int main() {
    int a;
    long b;
    char c;
    float d;
    double e;
    std::cin >> a >> b >> c >> d >> e;
    std::cout << a << std::endl << std::fixed << std::setprecision(3) << b << std::endl << c << std::endl << d << std::endl << std::setprecision(9) <<  e << std::endl;
    return 0;
}