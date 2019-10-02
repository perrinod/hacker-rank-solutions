//https://www.hackerrank.com/challenges/c-tutorial-functions/problem
#include <iostream>

int max_of_four(int a, int b, int c, int d){
    if(d > a)
        a = d;
    if(c > a)
        a = c;
    if(b > a)
        a = b;
    
    return a;
}

int main() {
    int a, b, c, d;
    std::cin >> a >> b >> c >> d;
    int ans = max_of_four(a, b, c, d);
    std::cout << ans;
    
    return 0;
}
