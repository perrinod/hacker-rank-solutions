// https://www.hackerrank.com/challenges/two-strings/problem
#include <bits/stdc++.h>

using namespace std;

string twoStrings(string s1, string s2) {
    set<char> characters;

    for(int i = 0; i < s1.size(); i++){
        characters.insert(s1[i]);
    }

    for(int i = 0; i < s2.size(); i++){
        set<char>::iterator iter = characters.find(s2[i]);
        if(iter != characters.end())
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
        string s1;
        getline(cin, s1);

        string s2;
        getline(cin, s2);

        string result = twoStrings(s1, s2);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}
