//https://www.hackerrank.com/challenges/anagram/problem
#include <bits/stdc++.h>

using namespace std;

int anagram(string s) {
    if(s.size() % 2 != 0)
        return -1;
    
    string s1 = s.substr(0, s.size() / 2);
    string s2 = s.substr(s.size() / 2, s.size());

    int count = 0;

    for(char letter : s1){
        size_t found = s2.find(letter);
        if(found != string::npos)
            s2.erase(s2.begin() + found);
        else
            count++;

    }

    return count;
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

        int result = anagram(s);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}
