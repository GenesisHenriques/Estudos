#include <iostream>
#include <string>


using namespace std;
int main() 
{
	int max;
	
	cout << "Quantos valores v�o ser digitados? ";
	cin >> max;
	
	int num[max];
	
	for (int cont; cont < max; cont++)
	{
		cout << "Digite o valor do " << (cont + 1)<<"� numero: ";
		cin >> num[cont];
		
    }
    
	for (int cont; cont < max; cont++)
	{
		cout <<"O numero digitado na "<< (cont + 1)<<"� posi��o �: "<< num[cont];
		cout <<"A";
	}
			
		return 0;
	
}
