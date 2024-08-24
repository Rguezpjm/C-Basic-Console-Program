namespace proyecto_Sueldo;

class Program
{
    static void Main(string[] args)
    {
       int numero_empleados;
       double sueldo;
       int empleadosentre = 0;
       int empleadosmasde = 0;
       double gastoTotal = 0;

       Console.WriteLine("Ingrese el numero de empleados: ");
       numero_empleados = int.Parse(Console.ReadLine());

       for ( int i = 1; i <= numero_empleados; i++){
        100
        Console.WriteLine($"Ingrese el sueldo del empleado {i}: $");
        sueldo = double.Parse(Console.ReadLine());

        if ( sueldo >= 100 && sueldo <= 300){
            empleadosentre++;
        }else if (sueldo > 300){
            empleadosmasde++;
        }
            gastoTotal += sueldo;
       }
    
        Console.WriteLine($"Empleados con sueldo entre $100 y $300: {empleadosentre}" );
        Console.WriteLine($"Empleados con sueldo mayor a $300: {empleadosmasde}" );
        Console.WriteLine($"Importe total en sueldos: ${gastoTotal}");


        Console.ReadKey();



    }
}
