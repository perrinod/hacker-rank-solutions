// https://www.hackerrank.com/challenges/save-the-prisoner/problem
#include <bits/stdc++.h>

using namespace std;

vector<string> split_string(string);

int saveThePrisoner(int n, int m, int s) {
    int seat = (m + s - 1) % n;
    return seat == 0 ? n : seat;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int t;
    cin >> t;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int t_itr = 0; t_itr < t; t_itr++) {
        string nms_temp;
        getline(cin, nms_temp);

        vector<string> nms = split_string(nms_temp);

        int n = stoi(nms[0]);

        int m = stoi(nms[1]);

        int s = stoi(nms[2]);

        int result = saveThePrisoner(n, m, s);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}