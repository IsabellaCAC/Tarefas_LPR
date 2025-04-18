#include <iostream>
using namespace std;

int numInvertido(int num) {
    int invertido = 0;
   
    while (num != 0) {
        int digito = num % 10;
        invertido = invertido * 10 + digito;
        num = num / 10;
    }

    return invertido;
}

int main() {
    int num;
    cout << "Digite um numero: ";
    cin >> num;

    int reverso = numInvertido(num);
    cout << "O numero invertido eh: " << reverso << endl;

    return 0;
}