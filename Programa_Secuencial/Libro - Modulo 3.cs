using System;

namespace Biblioteca
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public Libro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Páginas: {Paginas}");
        }

        public bool EsLargo()
        {
            return Paginas > 500;
        }
    }

    class Program
    {
        static void Main()
        {
            Libro libro = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 417);

            libro.MostrarInformacion();

            if (libro.EsLargo())
            {
                Console.WriteLine("El libro es largo.");
            }
            else
            {
                Console.WriteLine("El libro no es largo.");
            }
        }
    }
}
