//https://www.hackerrank.com/challenges/inheritance-introduction/problem
#include <iostream>

class Triangle{
    public:
    	void triangle(){
     		std::cout<<"I am a triangle\n";
    	}
};

class Isosceles : public Triangle{
    public:
    	void isosceles(){
    		std::cout<<"I am an isosceles triangle\n";
    	}
  		void description(){
              std::cout<<"In an isosceles triangle two sides are equal" << std::endl;
          }
};

int main(){
    Isosceles isc;
    isc.isosceles();
  	isc.description();
    isc.triangle();
    return 0;
}
