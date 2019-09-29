//https://www.hackerrank.com/challenges/staircase/problem
#include <bits/stdc++.h>

using namespace std;

// Complete the staircase function below.
void staircase(int n) {
    for(int i = 1; i < n + 1; i++){
        std::string spaces (n - i, ' ');
        std::string hashtag(i, '#');
        std::cout << spaces + hashtag << std::endl;
    }

}

int main()
{
    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    staircase(n);

    return 0;
}
