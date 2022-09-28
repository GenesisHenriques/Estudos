#include <iostream>

using namespace std;
int main() 
{
	int maxLinha, maxCar;
	
	cout << "Quantas linhas o programa deve mostrar?";
	cin >> maxLinha;
	cout << "Quantos caracteres a linha deve ter?";
	cin >> maxCar;
	
	for (int cont; cont < maxLinha ; cont++)
	{
		for(int contCar; contCar < maxCar; contCar++)
		{
			int a;
			if(contCar < a)
			{
				cout << "*";
			}
			else
			{
				cout << "+";
			}
			a++;
		}
		
	}
	return 0;
}
