//https://www.hackerrank.com/challenges/inherited-code/problem
#include <iostream>
#include <string>
#include <sstream>
#include <exception>
using namespace std;

struct BadLengthException : public exception{
    private:
        int n;
    public:
        BadLengthException(int e){
            n = e;
        }
        int what(){
            return n;
        }

};