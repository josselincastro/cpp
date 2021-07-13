using System;
using System.Collections.Generic;


public class Inventario
{

public List< Producto> Listadeproductos {get; set; }
}
public Inventario ()
{
ListadeProductos = new List<Producto> ();
Producto a = new Product ("001" , "iPhoneX" , 0);
Producto b = new Product ("002" , "Laptop Dell" , 5);
Producto c = new Product ("003" , "Monitor samsung" , 2);
Producto d = new Product ("004" , "Mouse" , 100);
Producto e = new Product ("005" , "Headset" , 25);

ListadeProductos.Add(a)
ListadeProductos.Add(b)
ListadeProductos.Add(c)
ListadeProductos.Add(d)
ListadeProductos.Add(e)
}
private void listarProductos(){
    console.Clear ();
    console.WriteLine("");
     console.WriteLine("Listado de Productos");
     console.WriteLine("********************");
     console.WriteLine("Codigo, Descripción y Existencia");

    
    foreach (var product in ListadeProductos)
    {
       console.WriteLine(productos.codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString()); 
    }
    Console.ReadLine();
}

private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento){
   foreach (var producto in ListadodeProductos)
    {
    if (producto.Codigo == codigo){
            if (tipoMovimiento == "+"){
                productos.Existencia = producto.Existencia + cantidad;
            } else {
                productos.Existencia = producto.Existencia - cantidad
                ;
            }
        }  
    }
}

public void ingresoDeInventario() {
    string codigo = "";
   string cantidad = "";

    console.Clear ();
    console.WriteLine("");

     console.WriteLine("Ingreso de Productos al Inventario");
     console.WriteLine("**********************************");
  console.WriteLine("Ingrese el codigo del producto");
  codigo = Console.ReadLine();
      console.WriteLine("Ingrese la cantidad del producto");
       cantidad = Console.ReadLine();
     
     movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }
}
private void listarProductos(){
    console.Clear ();
    console.WriteLine("");
     console.WriteLine("Listado de Productos");
     console.WriteLine("********************");
     console.WriteLine("Codigo, Descripción y Existencia");
}
   foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }

        Console.ReadLine();
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }

    public void ingresoDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }
} 

    