// https://www.hackerrank.com/challenges/strong-password/problem
#include <bits/stdc++.h>

using namespace std;

int minimumNumber(int n, string password) {
    int count = 0;
    regex lowerCase(".*[a-z].*");
    regex upperCase(".*[A-Z].*");
    regex digit(".*[0-9].*");
    regex specialCharacter("^[a-zA-Z0-9]*");

    if(!regex_match(password, lowerCase))
        count++;
    if(!regex_match(password, upperCase))
        count++;
    if(!regex_match(password, digit))
        count++;
    if(regex_match(password, specialCharacter))
        count++;

    return max(count, 6 - n);
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string password;
    getline(cin, password);

    int answer = minimumNumber(n, password);

    fout << answer << "\n";

    fout.close();

    return 0;
}