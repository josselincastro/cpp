using System.Collections.Generic;

namespace PilaresPoo
{
    class Program
    {
        static void Main(string[] args)
        {
             //Animal Mamifero= new Animal("Perro");
            //Mamifero.comer();

            // Animal Ave = new Animal("El loro");
            //Ave.dormir();

         // Herencia
         //Mamifero objetoMamifero = new Mamifero("Perro");
         //objetoMamifero.comer();

         //Ave objAve = new Ave("El loro");
         //objAve.dormir();   

         //polimorfismo
         Mamifero obj1 = new Mamifero("Perro");
         Mamifero obj2 = new Mamifero("Toro");
         Mamifero obj3 = new Mamifero("Cocodrilo");
         Mamifero obj4 = new Mamifero("Hipopotamo");
         Mamifero obj5 = new Mamifero("Leon");
         Mamifero obj6 = new Mamifero("Gato");
         Mamifero obj7 = new Mamifero("Mono");

         List<Animal>ListaMamiferos= new List<Animal>();
         ListaMamiferos.Add(obj1);
         ListaMamiferos.Add(obj2);
         ListaMamiferos.Add(obj3);
         ListaMamiferos.Add(obj4);
         ListaMamiferos.Add(obj5);
         ListaMamiferos.Add(obj6);
         ListaMamiferos.Add(obj7);

         foreach (Mamifero item in ListaMamiferos)
         {
             obj1.comer();
             obj2.dormir();

             
         }

         Ave obje1 = new Ave("El loro");
         Ave obje2 = new Ave("Guacamaya");
         Ave obje3 = new Ave("Lechuza");
         Ave obje4 = new Ave("Paloma");
         Ave obje5 = new Ave("Zopilote");
         Ave obje6 = new Ave("Flamenco");
         Ave obje7 = new Ave("Tucan");

         List<Animal>ListaAves= new List<Animal>();
         ListaAves.Add(obje1);
         ListaAves.Add(obje2);
         ListaAves.Add(obje3);
         ListaAves.Add(obje4);
         ListaAves.Add(obje5);
         ListaAves.Add(obje6);
         ListaAves.Add(obje7);

         foreach (Ave item in ListaAves)
         {
             obje1.comer();
             obje2.dormir();
             obje3.volar();

             
         }
        
         Pez ob1 = new Pez("Pez payaso");
         Pez ob2 = new Pez("Pez mandarin");
         Pez ob3 = new Pez("Pez globo");
         Pez ob4 = new Pez("Pez cebra");
         Pez ob5 = new Pez("Pez salmon");
         Pez ob6 = new Pez("Pez espada");
         Pez ob6 = new Pez("Pez betta");


         List<Animal>ListaPeces= new List<Animal>();
         ListaPeces.Add(ob1);
         ListaPeces.Add(ob2);
         ListaPeces.Add(ob3);
         ListaPeces.Add(ob4);
         ListaPeces.Add(ob5);
         ListaPeces.Add(ob6);
         ListaPeces.Add(ob7);

         foreach (Pez item in ListaPeces)
         {
             ob1.nadar();
             ob2.comer();
             


         }
    }
 }
}