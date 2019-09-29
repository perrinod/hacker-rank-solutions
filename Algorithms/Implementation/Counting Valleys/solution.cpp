//https://www.hackerrank.com/challenges/counting-valleys/problem
#include <bits/stdc++.h>

using namespace std;

int countingValleys(int n, string s) {
    int valley, count;
    valley = count = 0;
    bool downhill = false;

    for(int i = 0; i < n; i++){
        if(s[i] == 'U')
            valley++;
        else
        {
            if(valley == 0)
                downhill = true;

            valley--;
        }
        
        if(valley == 0 && downhill){
            count++;
            downhill = !downhill;
        }
    }

    return count;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string s;
    getline(cin, s);

    int result = countingValleys(n, s);

    fout << result << "\n";

    fout.close();

    return 0;
}
