//https://www.hackerrank.com/challenges/c-tutorial-class/problem
#include <iostream>
#include <sstream>
#include <string>

class Student{
    private:
        int age, standard;
        std::string first_name, last_name;
    public:
        void set_age(int age){
            this->age = age;
        }
        void set_standard(int standard){
            this->standard = standard;
        }
        void set_first_name(std::string first_name){
            this->first_name = first_name;
        }
        void set_last_name(std::string last_name){
            this->last_name = last_name;
        }
        int get_age(){
            return age;
        }
        int get_standard(){
            return standard;
        }
        std::string get_first_name(){
            return first_name;
        }
        std::string get_last_name(){
            return last_name;
        }
        std::string to_string(){
            return std::to_string(age) + "," + first_name + "," + last_name + "," + std::to_string(standard);
        }



};

int main() {
    int age, standard;
    std::string first_name, last_name;
    
    std::cin >> age >> first_name >> last_name >> standard;
    
    Student st;
    st.set_age(age);
    st.set_standard(standard);
    st.set_first_name(first_name);
    st.set_last_name(last_name);
    
    std::cout << st.get_age() << "\n";
    std::cout << st.get_last_name() << ", " << st.get_first_name() << "\n";
    std::cout << st.get_standard() << "\n";
    std::cout << "\n";
    std::cout << st.to_string();
    
    return 0;
}

