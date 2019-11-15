//https://www.hackerrank.com/challenges/making-anagrams/problem
#include <bits/stdc++.h>

using namespace std;

int makingAnagrams(string s1, string s2) {
    int count = 0;

    for(char letter : s1){
        size_t found = s2.find(letter);
        if(found != string::npos){
            s2.erase(s2.begin() + found);
            count++;
        }
    }

    return s1.size() - count + s2.size();

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s1;
    getline(cin, s1);

    string s2;
    getline(cin, s2);

    int result = makingAnagrams(s1, s2);

    fout << result << "\n";

    fout.close();

    return 0;
}