// https://www.hackerrank.com/challenges/maximizing-xor/problem
#include <bits/stdc++.h>

using namespace std;

int maximizingXor(int l, int r) {
    int largest = 0;

    for(int i = l; i <= r; i++)
        for(int j = l; j <= r; j++)
            largest = max(largest, i^j);

    return largest;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int l;
    cin >> l;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int r;
    cin >> r;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int result = maximizingXor(l, r);

    fout << result << "\n";

    fout.close();

    return 0;
}
