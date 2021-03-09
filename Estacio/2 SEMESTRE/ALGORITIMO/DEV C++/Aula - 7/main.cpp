#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <locale.h>

using namespace std;
int main() 
{
	int num = 10;
	cout << "Os numero pares entre 10 e 100 são:";
	
	cout <<num;	while( num < 102)
	{
		cout << num<<" ";
		num += 2;
	}

	return 0;
}
