int option;
Console.WriteLine("Selecciona el programa a ejecutar");
Console.WriteLine(" 1) Dado un conjunto de datos representando las dimensiones de triángulos, calcular y contar aquellos cuya área excede un valor límite.");
Console.WriteLine("2) Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.");
Console.WriteLine("3) Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.");

option = int.Parse(Console.ReadLine());

switch(option){
    case 1:
   double[] lados = new double[3];
string[] nombresLados = { "a", "b", "c" };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Introduce la longitud del lado {nombresLados[i]}: ");
    lados[i] = Convert.ToDouble(Console.ReadLine());
}

double s = (lados[0] + lados[1] + lados[2]) / 2;
double area = Math.Sqrt(s * (s - lados[0]) * (s - lados[1]) * (s - lados[2]));

Console.WriteLine($"El área del triángulo es: {area}");

    break;
    case 2:
         int contador = 0;

        for (int i = 1; i <= 10; i++) {
            Console.Write($"Introduce el número {i}: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 3 == 0 || numero % 5 == 0) {
                contador++;
            }
        }

        Console.WriteLine($"Hay {contador} números divisibles por 3 o 5 en el conjunto.");
    break;

    case 3:
 int[] numeros = new int[10];
        int suma = 0;

        for (int i = 0; i < 10; i++) {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 5; i < 10; i++) {
            suma += numeros[i];
        }

        Console.WriteLine($"La suma de los últimos 5 números es: {suma}");
    
    break;
    default:
        Console.WriteLine("Opcion no valida");
    break;
}
