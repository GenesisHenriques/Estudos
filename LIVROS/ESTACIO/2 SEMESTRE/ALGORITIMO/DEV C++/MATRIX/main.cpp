#include <iostream>

using namespace std;
int main() 
{
	setlocale(LC_ALL, "Portuguese");
	int maxLinha, maxCaracter;
	
	cout<< "Quantas Linhas o programa deve ter?";
	cin >> maxLinha;
	cout<< "E quantos caracteres cara linha deve ter?";
	cin >> maxCaracter;
		
	int num[maxLinha][maxCaracter];
	
	for (int contLinha = 0; contLinha < maxLinha; contLinha++)
	{
		for (int contCaracter = 0; contCaracter < maxCaracter; contCaracter++)
		{
			cout << "Digite um valor";
			cin >> num[maxLinha][maxCaracter];
		}
	}
	for (int contLinha = 0; contLinha < maxLinha; contLinha++)
	{
		for (int contCaracter = 0; contCaracter < maxCaracter; contCaracter++)
		{
			cout << "O valor digitado na posição [" << contLinha <<"," <<contCaracter <<"] foi: " <<num[maxLinha][maxCaracter];
			cout << "\n";
		}
	}
	
	
	
	
	return 0;
}
