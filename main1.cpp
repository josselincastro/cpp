# incluye  < iostream >
# incluir  < cadena >

usando el  espacio de nombres  std ;

cadena de productos [ 5 ] [ 3 ] = {
    { " 001 " , " iPhone X " , " 0 " },
    { " 002 " , " Laptop Dell " , " 5 " },
    { " 003 " , " Monitor Samsung " , " 2 " },
    { " 004 " , " Ratón " , " 100 " },
    { " 005 " , " HeadSet " , " 25 " }
};

void  listarProductos () {
    sistema ( " cls " );
    cout << endl;
    cout << " Listado de Productos " << endl;
    cout << " ******************** " << endl;
    cout << " Codigo, Descripcion y Existencia " << endl;

    para ( int i = 0 ; i < 5 ; i ++)
    {
        cout << productos [i] [ 0 ] << " | " << productos [i] [ 1 ] << " | " << productos [i] [ 2 ] << endl;
    }
}

void  movimientoInventario (string codigo, int cantidad, string tipoMovimiento) {
    para ( int i = 0 ; i < 5 ; i ++)
    {
        if (productos [i] [ 0 ] == codigo) {
            if (tipoMovimiento == " + " ) {
                productos [i] [ 2 ] = to_string ( stoi (productos [i] [ 2 ]) + cantidad);
            } más {
                productos [i] [ 2 ] = to_string ( stoi (productos [i] [ 2 ]) - cantidad);
            }
        }
    }
}

void  ingresoDeInventario () {
    cadena codigo = " " ;
    int cantidad = 0 ;

    sistema ( " cls " );
    cout << endl;
    cout << " Ingreso de Productos al Inventario " << endl;
    cout << " ********************************* " << endl;
    cout << " Ingrese el codigo del producto: " ;
    cin >> codigo;
    cout << endl;
    cout << " Ingrese la cantidad del producto: " ;
    cin >> cantidad;
    cout << endl;

    movimientoInventario (codigo, cantidad, " + " );
}
void  ajustepositivoDeInventario () {
    cadena codigo = " " ;
    int cantidad = 0 ;

    sistema ( " cls " );
    cout << endl;
    cout << " Ingreso de Productos al Inventario " << endl;
    cout << " ********************************* " << endl;
    cout << " Ingrese el codigo del producto: " ;
    cin >> codigo;
    cout << endl;
    cout << " Ingrese la cantidad del producto: " ;
    cin >> cantidad;
    cout << endl;

    movimientoInventario (codigo, cantidad, " + " );
}
void  salidaDeInventario () {
    cadena codigo = " " ;
    int cantidad = 0 ;

    sistema ( " cls " );
    cout << endl;
    cout << " Salida de Productos del Inventario " << endl;
    cout << " ********************************* " << endl;
    cout << " Ingrese el codigo del producto: " ;
    cin >> codigo;
    cout << endl;
    cout << " Ingrese la cantidad del producto: " ;
    cin >> cantidad;
    cout << endl;

    movimientoInventario (codigo, cantidad, " - " );
}
void  ajustenegativoDeInventario () {
    cadena codigo = " " ;
    int cantidad = 0 ;

    sistema ( " cls " );
    cout << endl;
    cout << " Salida de Productos del Inventario " << endl;
    cout << " ********************************* " << endl;
    cout << " Ingrese el codigo del producto: " ;
    cin >> codigo;
    cout << endl;
    cout << " Ingrese la cantidad del producto: " ;
    cin >> cantidad;
    cout << endl;

    movimientoInventario (codigo, cantidad, " - " );
}

int  main ( int argc, char  const * argv [])
{
    int opcion = 0 ;

    while ( verdadero ) {
        sistema ( " cls " );

        cout << " Sistema de Inventario " ;
        cout << endl;
        cout << " ******************** " ;
        cout << endl;
        cout << endl;
        cout << " 1 - Productos " << endl;
        cout << " 2 - Ingreso de Inventario " << endl;
        cout << " 3 - Salida de Inventario " << endl;
        cout << " 4 - Ajuste Negativo " << endl;
        cout << " 5 - Ajuste Positivo " << endl;
        cout << " 0 - Salir " << endl;
        cout << " Ingrese una opción del menú: " ;
        cin >> opcion;

        interruptor (opcion)
        {
        caso  1 :
            listarProductos ();            
            romper ;
        caso  2 :
            ingresoDeInventario ();
            romper ;
        caso  3 :
            salidaDeInventario ();
            romper ;
        caso  4 :
            ajustenegativoDeInventario ();
            romper ;
        caso  5 :
            ajustepositivoDeInventario ();
            romper ;
        por defecto :
            romper ;
        }

        sistema ( " pausa " );
        cout << endl;

        si (opcion == 0 ) {
            romper ;
        }
    }

 

    return  0 ;
}
