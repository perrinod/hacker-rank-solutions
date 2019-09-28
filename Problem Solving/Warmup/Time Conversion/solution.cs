#include <bits/stdc++.h>

using namespace std;

/*
 * Complete the timeConversion function below.
 */
string timeConversion(string s) {
    string meridian = s.substr(s.size() - 2, s.size());
    string ms = s.substr(2, s.size() - 4);
    int hour = std::stoi(s.substr(0,2));

    hour = ((meridian == "AM" && hour == 12) ? 0 : (meridian == "PM" && hour != 12) ? (hour + 12) : hour);

    return ((hour < 12) ? ('0' + to_string(hour)) : to_string(hour)) + ms;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    string result = timeConversion(s);

    fout << result << "\n";

    fout.close();

    return 0;
}