//https://www.hackerrank.com/challenges/find-digits/copy-from/115842909
#include <bits/stdc++.h>

using namespace std;

int findDigits(int n) {
    int digit, count = 0;

    string s = to_string(n);

    for(int i = 0; i < s.size(); i++){
        digit = s[i] - '0';

        if(digit != 0 && n % digit == 0)
            count++;
    }

    return count;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int t;
    cin >> t;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int t_itr = 0; t_itr < t; t_itr++) {
        int n;
        cin >> n;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        int result = findDigits(n);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}
