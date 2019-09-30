//https://www.hackerrank.com/challenges/strange-advertising/problem
#include <bits/stdc++.h>

using namespace std;

int viralAdvertising(int n) {
    int total = 0, floor = 5;
    
    for(int i = 0; i < n; i++){
        total += (floor / 2);
        floor = (floor / 2) * 3;
    }
    
    return total;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int result = viralAdvertising(n);

    fout << result << "\n";

    fout.close();

    return 0;
}
