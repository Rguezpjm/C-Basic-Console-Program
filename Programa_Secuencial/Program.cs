int option;
Console.WriteLine("Ingrese la opcion que deseas visualizar:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1. Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto.");
Console.WriteLine("2. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.");
Console.WriteLine("3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.");
option = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.White;
switch(option){
    case 1:
//1. Realizar la carga de dos numeros enteros por teclado e imprimir su suma y su producto.

Console.WriteLine("Ingrese el primer numero:");
int numero5 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero;");
int numero6 = int.Parse(Console.ReadLine());
int suma = numero5 + numero6;
int producto = numero5 * numero6;

Console.WriteLine("La suma de los dos numeros ingresados son: " + suma + " Su producto es: " +producto);
break;

case 2:

//2. Se debe desarrollar un programa que pida el ingreso del precio de un articulo y la cantidad que lleva el cliente. mostrar lo que debe abonar el comprador.
Console.WriteLine("Ingrese el Precio del articulo: ");
decimal precio = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingese la Cantidad:");
int cantidad = int.Parse(Console.ReadLine());

decimal Deuda = Convert.ToDecimal(precio*cantidad);

Console.WriteLine("El total a pagar es: " +Deuda);

break;
case 3:
//3. Realizar un programa que lea cuatro valores numericos e informar su suma y promedio.

Console.WriteLine("Ingrese el primer numero");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero");
int numero3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto numero");
int numero4 = int.Parse(Console.ReadLine());

int sumatoria = numero1 + numero2 + numero3 + numero4;
int promedio = sumatoria / 4;

Console.WriteLine("La Sumatoria de los cuatros numeros ingresados son:" +sumatoria);
Console.WriteLine("El Promedio es:" +promedio);
break;

default:
 Console.WriteLine("Opcion no valida.");
 break;
}