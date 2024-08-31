namespace proyecto_Sueldo;
using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Ingrese x cantidad de numeros:");
      int cantidad = int.Parse(Console.ReadLine());
      List<int> numeros = new List <int> ();

      Console.WriteLine("Ingrese los numeros:");
      for (int i = 0; i < cantidad; i++){
        numeros.Add(int.Parse(Console.ReadLine()));
      }
      int valormenor = numeros.Min();
      Console.WriteLine("El numero menor es:" +valormenor);
      bool repetidos = numeros.GroupBy(x => x).Any(g => g.Count() > 1);
      if (repetidos){
        Console.WriteLine("Hay valores Repetidos.");
      } else{
        Console.WriteLine("No hay valores repetidos");
      }

    }
}
