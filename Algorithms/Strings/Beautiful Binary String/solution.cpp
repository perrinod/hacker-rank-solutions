// https://www.hackerrank.com/challenges/beautiful-binary-string/problem
#include <bits/stdc++.h>

using namespace std;

int beautifulBinaryString(string b) {
    return (b.size() - regex_replace(b, regex("010"), "").size()) / 3;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string b;
    getline(cin, b);

    int result = beautifulBinaryString(b);

    fout << result << "\n";

    fout.close();

    return 0;
}
