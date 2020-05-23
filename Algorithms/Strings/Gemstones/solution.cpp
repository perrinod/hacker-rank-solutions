// https://www.hackerrank.com/challenges/gem-stones/problem
#include <bits/stdc++.h>

using namespace std;

int gemstones(vector<string> arr) {
    map<char,int> rocks;

    for(int i = 0; i < arr.size(); i++){
        for(int j = 0; j < arr[i].size(); j++){
            if(rocks[arr[i][j]] == i){
                rocks[arr[i][j]]++;
            }
        }
    }

    int count = 0;

    for(auto gem : rocks)
        if(gem.second == arr.size())
            count++;

    return count;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    vector<string> arr(n);

    for (int i = 0; i < n; i++) {
        string arr_item;
        getline(cin, arr_item);

        arr[i] = arr_item;
    }

    int result = gemstones(arr);

    fout << result << "\n";

    fout.close();

    return 0;
}
