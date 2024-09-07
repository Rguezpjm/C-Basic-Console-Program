using System;
using System.Collections.Generic;
using System.Linq;

public class Alumno
{
    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public string Carrera { get; set; }
    public List<int> Calificaciones { get; set; }

    public Alumno(string nombre, string matricula, string carrera, List<int> calificaciones)
    {
        Nombre = nombre;
        Matricula = matricula;
        Carrera = carrera;
        Calificaciones = calificaciones;
    }

    public double CalcularPromedio()
    {
        return Calificaciones.Average();
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
    }
}

public class Program
{
    public static void Main()
    {
        var alumno1 = new Alumno("Jose Rodriguez", "20220076", "Tecnico en Seguridad Informatica", new List<int> { 90, 85, 88, 92 });
        var alumno2 = new Alumno("Carlos Duran", "20210071", "Tecnico en Software", new List<int> { 95, 89, 94, 90 });

        alumno1.MostrarInformacion();
        Console.WriteLine();
        alumno2.MostrarInformacion();
    }
}
