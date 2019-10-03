//https://www.hackerrank.com/challenges/cpp-class-template-specialization/problem
#include <iostream>
using namespace std;
enum class Fruit { apple, orange, pear };
enum class Color { red, green, orange };

template <typename T> struct Traits;

template<typename T>
class Traits{
    public:
        static string name(int index){
            if(index == 0) return (typeid(T) == typeid(Fruit)) ? "apple" : "red";
            else if(index == 1) return (typeid(T) == typeid(Fruit)) ? "orange" : "green";
            else if(index == 2) return (typeid(T) == typeid(Fruit)) ? "pear" : "orange";
            else return "unknown";
        }
};

int main()
{
	int t = 0; std::cin >> t;

    for (int i=0; i!=t; ++i) {
        int index1; std::cin >> index1;
        int index2; std::cin >> index2;
        cout << Traits<Color>::name(index1) << " ";
        cout << Traits<Fruit>::name(index2) << "\n";
    }
}