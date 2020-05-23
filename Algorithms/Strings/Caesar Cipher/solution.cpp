// https://www.hackerrank.com/challenges/caesar-cipher-1/problem
#include <bits/stdc++.h>

using namespace std;

string caesarCipher(string s, int k) {

    for(int i = 0; i < s.size(); i++){
        if(isalpha(s[i])){
            char a = isupper(s[i]) ? 'A' : 'a';
            s[i] = a + (s[i] - a + k) % 26;
        }
    }

    return s;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string s;
    getline(cin, s);

    int k;
    cin >> k;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string result = caesarCipher(s, k);

    fout << result << "\n";

    fout.close();

    return 0;
}
