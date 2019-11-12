//https://www.hackerrank.com/challenges/mars-exploration/problem
#include <bits/stdc++.h>

using namespace std;

int marsExploration(string s) {
    int count = 0;
    string sos = "SOS";

    for(int i = 0; i < s.size(); i++){
        if(s[i] != sos[i % 3])
            count++;
    }

    return count;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    int result = marsExploration(s);

    fout << result << "\n";

    fout.close();

    return 0;
}