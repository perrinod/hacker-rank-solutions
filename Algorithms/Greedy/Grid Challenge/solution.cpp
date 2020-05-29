// https://www.hackerrank.com/challenges/grid-challenge/problem
#include <bits/stdc++.h>

using namespace std;

string gridChallenge(vector<string> grid) {

    sort(grid[0].begin(), grid[0].end());

    for(int i = 1; i < grid.size(); i++){
        sort(grid[i].begin(), grid[i].end());

        for(int j = 0; j < grid[i].size(); j++){
            if(grid[i-1][j] > grid[i][j])
                return "NO";
        }

    }

    return "YES";
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

        vector<string> grid(n);

        for (int i = 0; i < n; i++) {
            string grid_item;
            getline(cin, grid_item);

            grid[i] = grid_item;
        }

        string result = gridChallenge(grid);

        fout << result << "\n";
    }

    fout.close();