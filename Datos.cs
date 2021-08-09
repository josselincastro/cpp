using System;
using System.Collections.Generic;
using System.Text;

namespace NotasEscolares
{
    class Datos
    {
        private string nombre;
        private string matricula;
        private decimal nota1;
        private decimal nota2;
        private decimal nota3;
        private decimal nota4;
        private decimal nota5;
        private decimal promedio;
        private string literal;

        public void setNombre(string Nombre)
        {
            this.nombre= Nombre;

        }
         public void setMatricula(string Matricula)
        {
            this.matricula= Matricula;

        }
         public void setNota1(decimal Nota1)
        {
            this.nota1= Nota1;

        }
        public void setNota2(decimal Nota2)
        {
            this.nota2= Nota2;

        }
        public void setNota3(decimal Nota3)
        {
            this.nota3= Nota3;

        }
        public void setNota4(decimal Nota4)
        {
            this.nota4= Nota4;

        }
        public void setNota5(decimal Nota5)
        {
            this.nota5= Nota5;

        }

        public string getNombre()
        {
            return nombre;
        }
        public string getMatricula()
        {
            return matricula;
        }

        public decimal getPromedio()
        {
           
           promedio = (nota1+nota2+nota3+nota4+nota5) / 5;
           
            return promedio;

        }
        public string getLiteral()
        {
           if (promedio >=90 && promedio <=100) 
           {
               literal = "Literal A";
               Console.WriteLine("APROBASTES EXCELENTE!");
            estudiante.APROBASTES(decimal.Parse(Console.ReadLine()));
           }
           else
           if (promedio >=80 && promedio <=89) 
           {
               literal = "Literal B";
               Console.WriteLine("APROBASTES MUY BUENO!");
            estudiante.APROBASTES(decimal.Parse(Console.ReadLine()));
           }
           else
           if (promedio >=70 && promedio <=79) 
           {
               literal = "Literal C";
               Console.WriteLine("APROBASTES BUENO!");
            estudiante.APROBASTES(decimal.Parse(Console.ReadLine()));
           }
           else
           if (promedio>=0 && promedio  <=64) 
           {
               literal = "Literal F";
               Console.WriteLine("REPROBADO!");
            estudiante.REPROBADO(decimal.Parse(Console.ReadLine()));
           }

            
            return literal;
        }

    }
}