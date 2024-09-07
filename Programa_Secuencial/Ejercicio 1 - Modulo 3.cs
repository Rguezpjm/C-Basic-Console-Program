using System;

namespace proyecto_Sueldo
{
    public class Punto
    {
        private double x;
        private double y;

        public void CargarValores(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Cuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el segundo cuadrante.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el tercer cuadrante.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el cuarto cuadrante.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("El punto se encuentra sobre el eje Y.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("El punto se encuentra sobre el eje X.");
            }
            else
            {
                Console.WriteLine("El punto se encuentra en el origen.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Punto punto = new Punto();
            punto.CargarValores(3, 4);
            punto.Cuadrante();
        }
    }
}
