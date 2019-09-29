//https://www.hackerrank.com/challenges/encryption/copy-from/115838566
#include <bits/stdc++.h>

using namespace std;

string encryption(string s) {
    int size = s.size();
    string encrypted = "";
    int L = sqrt(size);
    int b = (L * L >= size) ? L : L + 1;
    
    for(int i = 0; i < b; i++){
        for(int j = i; j < size;){
            encrypted = encrypted + s[j];
            j = b + j;
        }
        encrypted = encrypted + " ";
    }

    return encrypted;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    string result = encryption(s);

    fout << result << "\n";

    fout.close();

    return 0;
}