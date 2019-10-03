//https://www.hackerrank.com/challenges/preprocessor-solution/problem
#define foreach(v, i) for(int i = 0; i < v.size(); i++) 
#define INF INT_MAX
#define FUNCTION(x, y)
#define io(v) cin >> v
#define toStr(str) #str
#define minimum(x, y) x = min(x, y)
#define maximum(x, y) x = max(x, y)
#include <climits>

#include <iostream>
#include <vector>
using namespace std;

#if !defined toStr || !defined io || !defined FUNCTION || !defined INF
#error Missing preprocessor definitions
#endif 

FUNCTION(minimum, <)
FUNCTION(maximum, >)

int main(){
	int n; cin >> n;
	vector<int> v(n);
	foreach(v, i) {
		io(v)[i];
	}
	int mn = INF;
	int mx = -INF;
	foreach(v, i) {
		minimum(mn, v[i]);
		maximum(mx, v[i]);
	}
	int ans = mx - mn;
	cout << toStr(Result =) <<' '<< ans;
	return 0;

}