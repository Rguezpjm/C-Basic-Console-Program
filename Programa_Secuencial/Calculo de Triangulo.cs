namespace proyecto_Sueldo;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Ingrese la cantidad de Triangulos que quiere Calcular:");
       int total_triangulo = int.Parse(Console.ReadLine());

       int contador_triangulo = 0;

       for (int i = 1; i <= total_triangulo; i++){
         Console.WriteLine($"Triangulo {i}:");
         Console.WriteLine("Ingrese la base: ");
         double baseTriangulo = double.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese la altura: ");
         double altura = double.Parse(Console.ReadLine());

         double area = (baseTriangulo * altura) / 2;
         Console.WriteLine($"Base: {baseTriangulo}, Altura: {altura}, Area: {area}");

         if (area > 12){
            contador_triangulo++;
         }
       }
    }
}
