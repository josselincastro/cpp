using System;
using System.Collections.Generic;
using System.Text;

namespace NotasEscolares
{
    class Program
    {
        static void Main(string[] args)
        {

           Datos estudiante = new Datos();

            Console.WriteLine("Escriba el nombre: ");
            estudiante.setNombre(Console.ReadLine());

            Console.WriteLine("Escriba la matricula: ");
            estudiante.setMatricula(Console.ReadLine());

            Console.WriteLine("Ver clases disponibles: ");
            estudiante.setdisponibles(Console.ReadLine());

            Console.WriteLine("Nota 1: ");
            estudiante.setNota1(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Nota 2: ");
            estudiante.setNota2(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Nota 3: ");
            estudiante.setNota3(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Nota 4: ");
            estudiante.setNota4(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Nota 5: ");
            estudiante.setNota5(decimal.Parse(Console.ReadLine()));
            
            Console.WriteLine("*//////******** ");
            Console.WriteLine("Nombre: "+ estudiante.getNombre());
            Console.WriteLine("Matricula: "+ estudiante.getMatricula());
            Console.WriteLine("Clases disponibles: "+ estudiante.getdisponibles());
            Console.WriteLine("Promedio: "+ estudiante.getPromedio());
            Console.WriteLine("Literal: "+ estudiante.getLiteral());


            Console.ReadKey();
        }
    }
}