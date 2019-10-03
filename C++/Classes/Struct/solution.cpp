//https://www.hackerrank.com/challenges/c-tutorial-struct/problem
#include <iostream>
#include <string>

struct Student{
    std::string age;
    std::string first_name;
    std::string last_name;
    std::string standard;
};

int main() {
    Student st;
    
    std::cin >> st.age >> st.first_name >> st.last_name >> st.standard;
    std::cout << st.age << " " << st.first_name << " " << st.last_name << " " << st.standard;
    
    return 0;
}

