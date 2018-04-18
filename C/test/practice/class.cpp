/*************************************************************************
	> File Name: class.cpp
	> Author: 
	> Mail: 
	> Created Time: 2017年10月14日 星期六 10时45分36秒
 ************************************************************************/

#include<iostream>
#include <string.h>
#include <stdlib.h>
using namespace std;

/*
class Student{
private:
    string name;
    int age;
public:
    Student(){
        cout<<"default"<<endl;
    }
    
    
    Student(string n, int a){
        name = n;
        age = a;
    }

    //Student(string n, int a):name(n),age(a){};

    Student(const Student &s){
        cout<<"copy func"<<endl;
    }

    Student & operator=(const Student &y){
        cout<<"give func"<<endl;
    }

    
    void Stu(const Student &t){
        this->name = t.name;
        this->age  = t.age;
        cout<<"cons func"<<endl;
    }
    

    void getName(string);
    void getAge(int);

    ~Student(){
        cout<<"~student"<<endl;
    }
};
*/

class Tt{
public:
    int func(int a, int b = 0){};
    int func(int a){};
};


/*
class A{
private:
    //...
public:
    A(){};
    A(int x, int y){};
};
*/

int main(void)
{

    Tt t;
    t.func(5);

    //Student stu("roux", 20);
 
    /*
    A a();   //error   function is a()  or  object
    A b;     //right
    A *p = new A();  //right
    */

    /*
    Student s = stu;
    Student st;
    st = stu;
    */

    /*
    int z = 10;
    //int &c = 10;  //error
    const int &c = 10;
    int &y = z;
    int *q = &z;
    cout<<y<<endl;
    cout<<&c<<endl;

    (*q)++;
    z = (*q);
    cout<<z<<endl;
    */

    /*
    int a = 10;
    int &b = a;
    int &c = b;
    cout<<a<<b<<c<<endl;
    */

    /*
    int *p = NULL;
    int *&q = p;
    q = (int *)malloc(sizeof(int));

    char y = 'a';
    char &x = y;
    cout<<sizeof(x)<<endl;
    */

    return 0;
}
