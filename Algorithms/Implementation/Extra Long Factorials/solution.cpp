// https://www.hackerrank.com/challenges/extra-long-factorials/problem
#include <bits/stdc++.h>

using namespace std;

void extraLongFactorials(int n) {
    vector<int> digits;
    int number = n;

    while(number > 0){
        digits.push_back(number % 10);
        number /= 10;
    }

    for(int i = n - 1; i > 1; i--){
        int carry = 0;

        for(int j = 0; j < digits.size(); j++){
            int product = digits[j] * i + carry;
            digits[j] = product % 10;
            carry = product / 10;
        }

        while(carry > 0){
            digits.push_back(carry % 10);
            carry /= 10;
        }
    } 

    for(int i = digits.size() - 1; i >= 0; i--)
        cout << digits[i];
    cout << endl;

}

int main()
{
    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    extraLongFactorials(n);

    return 0;
}
