//https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
#include <bits/stdc++.h>

using namespace std;

string hackerrankInString(string s) {
    string hackerRank = "hackerrank";
    if(s.size() < hackerRank.size())
        return "NO";

    int i = 0;
    for(char c : s){
        if(hackerRank[i] == c)
            i++;
        
        if(i == hackerRank.size())
            return "YES";
    }

    return "NO";
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int q;
    cin >> q;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int q_itr = 0; q_itr < q; q_itr++) {
        string s;
        getline(cin, s);

        string result = hackerrankInString(s);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}