#include <iostream>
#include "startShip.h"
#include "snake.cpp"
#include <string.h>
using namespace std;

string juegos [2] [2] = {
    {"1", "starShip ()"},
    {"2", "snake ()"},
};

int main (int argc, char const * argv [])
{
    int opcion = 0;

    while (true) {
        
        system ("cls");

        cout << endl;
        cout << "** ZavMur **" << endl;
        cout << "* Menú de Juegos *" << endl;
        cout << "** ZavMur **" << endl;
        cout << endl;
        cout << "¡ELIGE TU RETO DE HOY PARA JUGAR!" << endl;
        cout << endl;
        cout << "1 - starShip" << endl;
        cout << "2 - snake" << endl;
        cout << "0 - Salir" << endl;
        cout << endl;
        cout << "Ingrese una opción del menú, Y QUE INICIE EL JUEGO:";
        cin >> opcion;
        
        switch (opcion)
        {
        case 1:
            starShip ();
            break;
        
        case 2:
            snake();
            break;
         
    default:
        break;
        }

        system ("pausa");
        cout << endl;
        if (opcion == 0)
        {
            return;
        }
    }
    return 0;
}