//https://www.hackerrank.com/challenges/pangrams/problem
#include <bits/stdc++.h>

using namespace std;

string pangrams(string s) {
    std::set<char> sentence;
    
    for(char letter : s){
        sentence.insert(std::tolower(letter));
        if(sentence.size() == 27)
            return "pangram";
    }

    return "not pangram";

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    string result = pangrams(s);

    fout << result << "\n";

    fout.close();

    return 0;
}
