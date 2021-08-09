using System;
using System.Collections.Generic;

public class VerAsignaturas
{

    public List<Informatica> ListadeLenguaje { get; set; }
    public List<Informatica> ListadeTaller { get; set; }
    public List<Informatica> ListadeMetodologia { get; set; }         

    public VerAsignaturas()
    {
        ListadeIntroduccion = new List<Informatica>();
        Informatica A1 = new Informatica("01)", "Lenguaje de programacion:", 0700, "LuMaMiJue",30,"Billy Fernandez");
        ListadeIntroduccion.Add(A1);
        Informatica A2 = new Informatica("02)", "Lenguaje de programacion:", 0710, "LuMaMiJue",30,"Billy Fernandez");
        ListadeIntroduccion.Add(A2);
        Informatica A3 = new Informatica("03)", "Lenguaje de programacion:", 0800, "LuMaMiJue",30,"Billy Fernandez");
        ListadeIntroduccion.Add(A3);

        ListadeTaller = new List<Informatica>();
        Informatica T1 = new Informatica("04)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Billy Fernandez");
        ListadeTaller.Add(T1);
        Informatica T2 = new Informatica("05)", "Taller de Hardware 2", 0701, "LuMaMiJue",30,"Billy Fernandez");
        ListadeTaller.Add(T2);
        Informatica T3 = new Informatica("06)", "Taller de Hardware 1", 0700, "JuevesViernes",30,"Billy Fernandez");
        ListadeTaller.Add(T3);

        ListadeMetodologia = new List<Informatica>();
        Informatica M1 = new Informatica("07)", "Metodologia", 0700, "LuMaMiJue",30,"Billy Fernandez");
        ListadeMetodologia.Add(M1);
        Informatica M2 = new Informatica("08)", "Metodologia", 0701, "LuMaMiJue",30,"Billy Fernandez");
        ListadeMetodologia.Add(M2);
        Informatica M3 = new Informatica("09)", "Metodologia", 0715, "JuevesViernes",30,"Billy Fernandez");
        ListadeMetodologia.Add(M3);

    }
public void VerClasesDisponibles()
{
    
}
    public void Intro()
    {
        Console.Clear();
        Console.WriteLine("Asignaturas y Secciones");
        Console.WriteLine("");
        Console.WriteLine("             Asignatura           |Secc | Horarios  | Cupos | Profesor");
        Console.WriteLine("Lenguaje de programacion --------------------------------------------------------------------");
        foreach (var In in ListadeLenguaje)
        {
            Console.WriteLine(In.Codigo + " | " + In.Clase + "  | " + In.Seccion + " | " + In.Horario + " | " + In.Cupos + "    | " + In.Profesor);
        } 
    
    }

    public void Taller()
    {
        foreach (var Ta in ListadeTaller)
        {
            Console.WriteLine(Ta.Codigo + " | " + Ta.Clase + "        | " + Ta.Seccion + " | " + Ta.Horario + " | " + Ta.Cupos + "    | " + Ta.Profesor);
        }
       
    }

    public void Metodo()
    {
        foreach (var Me in ListadeMetodologia)
        {
            Console.WriteLine(Me.Codigo + " | " + Me.Clase + "        | " + Me.Seccion + " | " + Me.Horario + " | " + Me.Cupos + "    | " + Me.Profesor);
        }
        Console.ReadLine();
    }


   
}