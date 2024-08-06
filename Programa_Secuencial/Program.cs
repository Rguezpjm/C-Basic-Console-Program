//1.Diseñar un programa que solicite al usuario 
//dos números y, si el primer número es más
// grande, calcule y muestre su suma y resta.
//  De lo contrario, calculará y mostrará su 
 // producto y cociente.

Console.WriteLine("Ingrese el Primer Numero:");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo Numero: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

if (numero1 > numero2){
    double suma = numero1 + numero2;
    double resta = numero1 - numero2;
    Console.WriteLine($"suma: {suma}");
    Console.WriteLine($"resta: {resta}");
}else{
    double producto = numero1 * numero2;
    double cociente = numero1 / numero2;
    Console.WriteLine($"Producto: {producto}");
    Console.WriteLine($"Cociente: {cociente}");
}
Console.ReadKey();

// 2) Leer tres calificaciones y calcular el promedio. Si el promedio es igual o superior a siete, imprimir un mensaje indicando que el alumno ha aprobado.

Console.WriteLine("Ingrese la Primera Califiacion");
double Califiacion = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Ingrese la Segunda Califiacion");
double Califiacion2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Ingrese la Tercera Califiacion");
double Califiacion3 = Convert.ToDouble(Console.ReadLine());

double promedio = (Califiacion + Califiacion2 + Califiacion3) / 3;
Console.WriteLine($"El promedio es: {promedio}");

if (promedio >= 7){
    Console.WriteLine("El Alumno Ha aprobado");
}else{
    Console.WriteLine("El alumno no ha aprobado");
}
Console.ReadKey();


// 3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. El programa recibirá como entrada el número total de preguntas y las respuestas correctas, y devolverá un nivel según el porcentaje de aciertos.

//     Nivel máximo: Porcentaje>=90%.

//     Nivel medio: Porcentaje>=75% y <90%.

//     Nivel regular: Porcentaje>=50% y <75%.

//     Fuera de nivel: Porcentaje<50%.

Console.WriteLine("Ingrese el numero total de preguntas:");
int totalpreguntas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el número de respuestas correctas:");
            int respuestasCorrectas = Convert.ToInt32(Console.ReadLine());

            double porcentajeAciertos = (respuestasCorrectas * 100.0) / totalpreguntas;

            Console.WriteLine($"Porcentaje de aciertos: {porcentajeAciertos}%");
if (porcentajeAciertos >= 90)
            {
                Console.WriteLine("Nivel máximo");
            }
            else if (porcentajeAciertos >= 75)
            {
                Console.WriteLine("Nivel medio");
            }
            else if (porcentajeAciertos >= 50)
            {
                Console.WriteLine("Nivel regular");
            }
            else
            {
                Console.WriteLine("Fuera de nivel");
            }