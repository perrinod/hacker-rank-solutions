//https://www.hackerrank.com/challenges/utopian-tree/problem
#include <bits/stdc++.h>

using namespace std;

int utopianTree(int n) {
    int size = 1;

    if(n == 0)
        return size;

    bool season = true;

    while(n > 0){
        
        if(season)
            size *= 2;
        else
            size++;

        season = !season;
        n--;
    }

    return size;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int t;
    cin >> t;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int t_itr = 0; t_itr < t; t_itr++) {
        int n;
        cin >> n;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        int result = utopianTree(n);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}