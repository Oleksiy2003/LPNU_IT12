// Lab_02.cpp
// < Лопацький Олексій >
// Лабораторна робота № 2.
// Лінійні програми.
// Варіант 9.

#include <iostream>
#include <cmath>
using namespace std;




int main()
{
    double a;
    double b;
    double z1;
    double z2;
    char symbol;
    

    cin >> a;
    cin >> b;
    

    //int c = A_plus_B_To_Square(a, b,symbol);
     z1 = pow((cos(a) - cos(b)), 2) - pow((sin(a) - sin(b)), 2);
     z2 = -4*pow(sin((a - b) / 2),2)*cos(a+b);
        /* (cos(a) - cos(b)) * (cos(a) - cos(b)) - (sin(a) - sin(b)) * (sin(a) - sin(b));*/

    cout << "z1=:"<< z1 << endl;
    cout << "z2=:"<< z2 << endl;
    

   
    cin.get();
    return 0;
}
