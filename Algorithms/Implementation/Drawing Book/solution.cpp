//https://www.hackerrank.com/challenges/drawing-book/problem
#include <bits/stdc++.h>

using namespace std;

int pageCount(int n, int p) {
    if(n == p || p == 1)
       return 0;

    if(n % 2 == 0)
       n = n + 1;

    int back = (n - p) / 2;
    int front = p / 2;
    
    if (front > back)
         return back;

    return front;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int p;
    cin >> p;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int result = pageCount(n, p);

    fout << result << "\n";

    fout.close();

    return 0;
}