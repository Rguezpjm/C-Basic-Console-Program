   int contador = 0;
        int suma = 0;

        while (contador < 10) {
            Console.Write("Introduce un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            suma += numero;
            contador++;
        }

        double promedio = (double)suma / 10;
        Console.WriteLine($"La suma de los números es: {suma}");
        Console.WriteLine($"El promedio aritmético es: {promedio:F2}");