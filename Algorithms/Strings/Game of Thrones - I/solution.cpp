//https://www.hackerrank.com/challenges/game-of-thrones/problem
#include <bits/stdc++.h>

using namespace std;

string gameOfThrones(string s) {
    std::sort(s.begin(), s.end());

    bool palindrome = s.size() % 2 == 0 ? true : false;

    for(int i = 0, j = 0; j < s.size(); j++){
        if(s[i] != s[j]){
            if((j - i) % 2 != 0){
                if(palindrome)
                    return "NO";
                palindrome = true;
            }
            
            i = j;
        }
    }

    return "YES";
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    string result = gameOfThrones(s);

    fout << result << "\n";

    fout.close();

    return 0;
}