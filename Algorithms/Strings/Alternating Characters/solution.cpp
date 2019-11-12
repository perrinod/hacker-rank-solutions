//https://www.hackerrank.com/challenges/alternating-characters/problem
#include <bits/stdc++.h>

using namespace std;

int alternatingCharacters(string s) {
    count = 0;
    
    for(int i = 0, j = 1; j < s.size(); j++){
        if(s[i] == s[j])
            count++;
        else 
            i = j;
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

        int result = alternatingCharacters(s);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}