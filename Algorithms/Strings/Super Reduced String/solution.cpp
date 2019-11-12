//https://www.hackerrank.com/challenges/reduced-string/problem
#include <bits/stdc++.h>

using namespace std;

string superReducedString(string s) {
    
    int i = 0;
    while(i < s.size()){
        if(s[i] == s[i+1]){
            s = s.erase(i, 2);
            if(i != 0)
                i--;
        }
        else
            i++;
    }

    if(s.size() == 0)
        s = "Empty String";

    return s;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    string result = superReducedString(s);

    fout << result << "\n";

    fout.close();

    return 0;
}