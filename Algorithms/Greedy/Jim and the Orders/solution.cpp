// https://www.hackerrank.com/challenges/jim-and-the-orders/problem
#include <bits/stdc++.h>

using namespace std;

vector<int> jimOrders(vector<vector<int>> orders) {
    multimap<int, int> totalOrder;
    for(int i = 0; i < orders.size(); i++){
        int total = orders[i][0] + orders[i][1];
        totalOrder.insert(make_pair(total, i+1));
    }

    vector<int> orderNumber;

    for(multimap<int,int>::iterator i = totalOrder.begin(); i != totalOrder.end(); ++i)
        orderNumber.push_back(i->second);

    return orderNumber;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    vector<vector<int>> orders(n);
    for (int i = 0; i < n; i++) {
        orders[i].resize(2);

        for (int j = 0; j < 2; j++) {
            cin >> orders[i][j];
        }

        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    vector<int> result = jimOrders(orders);

    for (int i = 0; i < result.size(); i++) {
        fout << result[i];

        if (i != result.size() - 1) {
            fout << " ";
        }
    }

    fout << "\n";

    fout.close();

    return 0;
}