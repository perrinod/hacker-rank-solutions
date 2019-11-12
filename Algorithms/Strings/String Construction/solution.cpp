//https://www.hackerrank.com/challenges/string-construction/problem
#include <bits/stdc++.h>

using namespace std;

int stringConstruction(string s) {
    std::set<char> characters;

    for(char c : s)
        characters.insert(c);

    return characters.size();
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

        int result = stringConstruction(s);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}
