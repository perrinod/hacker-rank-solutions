//https://www.hackerrank.com/challenges/box-it
#include<bits/stdc++.h>
using namespace std;

class Box{
    private:
        int l, b, h;
    public:
        Box(){
            l = 0;
            b = 0;
            h = 0;
        }
        Box(int l, int b, int h){
            this->l = l;
            this->b = b;
            this->h = h;
        }
        Box(Box& box){
            this->l = box.getLength();
            this->b = box.getBreadth();
            this->h = box.getHeight();
        }
        int getLength(){
            return l;
        }
        int getBreadth(){
            return b;
        }
        int getHeight(){
            return h;
        }
        long long CalculateVolume(){
            return (long long) l * b * h;
        }
        bool operator < (Box& box){
            if((l < box.getLength()) || (b < box.getBreadth() && l == box.getLength()) ||(h < box.getHeight() && l == box.getLength() && b == box.getBreadth()))
                return true;
            
            return false;
        }
};

ostream& operator << (ostream& out, Box& B){
            out << B.getLength() << " " << B.getBreadth() << " " << B.getHeight();
            return out;
}