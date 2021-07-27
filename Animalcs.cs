using System;

namespace PilaresPoo
{
   public class Animal
   {
     protected string Nombre;

        public string _Nombre { get => Nombre; set => Nombre = value; }

        public void comer()
{
   Console.WriteLine(_Nombre+ " esta comiendo");
}
public void dormir()
{
   Console.WriteLine(_Nombre+ " esta durmiendo");
}

public void nadar()
{
   Console.WriteLine(_Nombre+ " esta nadando");
}

public void volar()
{
   Console.WriteLine(_Nombre+ " esta volando");
}


public Animal(string nombre){
   Nombre=nombre;
}

   }
   
}