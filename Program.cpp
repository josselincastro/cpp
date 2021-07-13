using system;

namespace funciones
{

	class Program
	{
		
		static void Main(string[] args)
		{
			Alumno a = new Alumno(1, "Juan", "Perez");	
			Alumno b = new Alumno(2, "Maria", "Martinez");	
			
			a.inactivarAlumno();
			
			Console.writeLine(a.nombreCompleto());
			Console.writeLine(b.nombreCompleto());
			
			a.activarAlumno();
			
			console.WriteLine("");
			
			Console.writeLine(a.nombreCompleto());
			Console.writeLine(b.nombreCompleto());
		}
	}
}
