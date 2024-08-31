namespace proyecto_Sueldo;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Ingrese el primer elemento de la matriz separado por espacios:");
       int [] primerlemento = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

       Console.WriteLine("Ingrese el segundo elemento de la matriz separado por espacios:");
       int [] segundoelemento = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool igualdad = primerlemento.SequenceEqual(segundoelemento);    
        if (igualdad){
            Console.WriteLine("Las matrices son iguales.");
        }else{
            Console.WriteLine("Las matrices no son iguales.");
        }
    }
}
