//https://www.hackerrank.com/challenges/funny-string/problem
#include <bits/stdc++.h>

using namespace std;

string funnyString(string s) {
    for(int i = 0, j = s.size() - 1; i < s.size() - 1; i++, j--){
        if(abs(s[i] - s[i+1]) != abs(s[j] - s[j-1]))
            return "Not Funny";
    }

    return "Funny";

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

        string result = funnyString(s);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}