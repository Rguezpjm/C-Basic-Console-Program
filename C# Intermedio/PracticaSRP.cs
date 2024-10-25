namespace Practicas_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Jose Rodriguez", 28, "Sembrador II, Ciudad Juan Bosch, Santo Domingo Este", "Rguezpjm@gmail.com");
            ServicioDeEntrada servicioDeEntrada = new ServicioDeEntrada();
            ServiciodeEnvio serviciodeEnvio = new ServiciodeEnvio();
            servicioDeEntrada.ImprimirDatos(persona);
            serviciodeEnvio.EnviarCorreo(persona.GetcorreoElectronico(), "Este es un mensaje de prueba.");
        }
    }


    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public string GetNombre() => nombre;
        public int GetEdad() => edad;
        public string GetDireccion() => direccion;
        public string GetcorreoElectronico() => correoElectronico;
    }

   
    public class ServiciodeEnvio
    {
        public void EnviarCorreo(string direccionCorreo, string mensaje)
        {
            Console.WriteLine($"Enviando correo a {direccionCorreo} con el mensaje: {mensaje}");
        }
    }


    public class ServicioDeEntrada
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.GetNombre()}");
            Console.WriteLine($"Edad: {persona.GetEdad()}");
            Console.WriteLine($"Direccion: {persona.GetDireccion()}");
            Console.WriteLine($"Correo Electronico: {persona.GetcorreoElectronico()}");
        }
    }
}
