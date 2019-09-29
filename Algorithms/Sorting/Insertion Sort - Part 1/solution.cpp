//https://www.hackerrank.com/challenges/insertionsort1/problem
#include <bits/stdc++.h>

using namespace std;

vector<string> split_string(string);

void print(std::vector<int> arr){
    for(std::vector<int>::iterator i = arr.begin(); i != arr.end(); ++i){
        std::cout << *i << " ";
    }
    std::cout << std::endl;
}

void insertionSort1(int n, vector<int> arr) {
    int insertValue = arr.back();
    int j = n - 2;
    
    while(j >= 0){
        if(insertValue < arr[j])
            arr[j + 1] = arr[j];
        else
            break;

        j--;
        print(arr);
    }

    arr[j + 1] = insertValue;
    print(arr);
}

int main()
{
    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string arr_temp_temp;
    getline(cin, arr_temp_temp);

    vector<string> arr_temp = split_string(arr_temp_temp);

    vector<int> arr(n);

    for (int i = 0; i < n; i++) {
        int arr_item = stoi(arr_temp[i]);

        arr[i] = arr_item;
    }

    insertionSort1(n, arr);

    return 0;
}

vector<string> split_string(string input_string) {
    string::iterator new_end = unique(input_string.begin(), input_string.end(), [] (const char &x, const char &y) {
        return x == y and x == ' ';
    });

    input_string.erase(new_end, input_string.end());

    while (input_string[input_string.length() - 1] == ' ') {
        input_string.pop_back();
    }

    vector<string> splits;
    char delimiter = ' ';

    size_t i = 0;
    size_t pos = input_string.find(delimiter);

    while (pos != string::npos) {
        splits.push_back(input_string.substr(i, pos - i));

        i = pos + 1;
        pos = input_string.find(delimiter, i);
    }

    splits.push_back(input_string.substr(i, min(pos, input_string.length()) - i + 1));

    return splits;
}