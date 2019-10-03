//https://www.hackerrank.com/challenges/classes-objects/problem
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <cassert>
using namespace std;

class Student{
    private:
        std::vector<int> scores;
    public:
        void input(){
            int score;
            for(int i = 0; i < 5; i++){
                std::cin >> score;
                scores.push_back(score);
            }
        }
        int calculateTotalScore(){
            int total = 0;
            for(int& score : scores)
                total = score + total;
            return total;
        }
};

int main() {
    int n; // number of students
    cin >> n;
    Student *s = new Student[n]; // an array of n students
    
    for(int i = 0; i < n; i++){
        s[i].input();
    }

    // calculate kristen's score
    int kristen_score = s[0].calculateTotalScore();

    // determine how many students scored higher than kristen
    int count = 0; 
    for(int i = 1; i < n; i++){
        int total = s[i].calculateTotalScore();
        if(total > kristen_score){
            count++;
        }
    }

    // print result
    cout << count;
    
    return 0;
}
