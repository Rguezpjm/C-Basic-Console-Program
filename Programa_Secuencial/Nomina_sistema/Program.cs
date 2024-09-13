using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;

namespace Nomina_Proyecto
{
    class Program
    {
        static List<Empleado> empleados = new List<Empleado>();

        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------+----------------------+----------------------+----------------------+");
            
Console.WriteLine("············································································");
Console.WriteLine(": /$$$$$$$ /$$$$$$$  /$$$$$$ /$$     /$$/$$$$$$$$ /$$$$$$ /$$$$$$$$/$$$$$$ :");
Console.WriteLine(":| $$__  $| $$__  $$/$$__  $|  $$   /$$| $$_____//$$__  $|__  $$__/$$  $$:");
Console.WriteLine(":| $$    $| $$    $| $$    $$   $$ /$$/| $$     | $$   __/  | $$ | $$    $$:");
Console.WriteLine(":| $$$$$$$| $$$$$$$| $$  | $$    $$$$/ | $$$$$  | $$        | $$ | $$    $$:");
Console.WriteLine(":| $$____/| $$__  $| $$  | $$     $$/  | $$__/  | $$        | $$ | $$    $$:");
Console.WriteLine(":| $$     | $$    $| $$  | $$   | $$   | $$     | $$    $$  | $$ | $$    $$:");
Console.WriteLine(":| $$     | $$  | $|  $$$$$$/   | $$   | $$$$$$$|  $$$$$$/  | $$ |  $$$$$$/:");
Console.WriteLine(":|__/     |__/  |__/ ______/    |__/   |________/ ______/   |__/   ______/ :");
Console.WriteLine(":                                                                          :");
Console.WriteLine(":                                                                          :");
Console.WriteLine(":                                                                          :");
Console.WriteLine(": /$$   /$$ /$$$$$$ /$$      /$$/$$$$$$/$$   /$$ /$$$$$$                   :");
Console.WriteLine(":| $$$ | $$/$$__  $| $$$    /$$|_  $$_| $$$ | $$/$$__  $$                  :");
Console.WriteLine(":| $$$$| $| $$    $| $$$$  /$$$$ | $$ | $$$$| $| $$    $$                  :");
Console.WriteLine(":| $$ $$ $| $$  | $| $$ $$/$$ $$ | $$ | $$ $$ $| $$$$$$$$                  :");
Console.WriteLine(":| $$  $$$| $$  | $| $$  $$$| $$ | $$ | $$  $$$| $$__  $$                  :");
Console.WriteLine(":| $$   $$| $$  | $| $$   $ | $$ | $$ | $$   $$| $$  | $$                  :");
Console.WriteLine(":| $$    $|  $$$$$$| $$  /  | $$/$$$$$| $$    $| $$  | $$                  :");
Console.WriteLine(":|__/   __/ ______/|__/     |__|______|__/   __|__/  |__/                  :");
Console.WriteLine("············································································");
            Console.WriteLine("+----------------------+----------------------+----------------------+----------------------+");
            Console.WriteLine("¿Desea agregar un nuevo empleado? (s/n)");
            string? respuesta = Console.ReadLine();

            if (!string.IsNullOrEmpty(respuesta) && respuesta.ToLower() == "s")
            {
                Console.WriteLine("Ingrese el tipo de empleado (1 para asalariado, 2 para por horas):");
                string? tipoEmpleadoStr = Console.ReadLine();
                if (int.TryParse(tipoEmpleadoStr, out int tipoEmpleado))
                {
                    Console.WriteLine("Ingrese el primer nombre:");
                    string? primerNombre = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido paterno:");
                    string? apellidoPaterno = Console.ReadLine();

                    Console.WriteLine("Ingrese el número de seguro social:");
                    string? seguroSocial = Console.ReadLine();

                    if (!string.IsNullOrEmpty(primerNombre) && !string.IsNullOrEmpty(apellidoPaterno) && !string.IsNullOrEmpty(seguroSocial))
                    {
                        if (tipoEmpleado == 1)
                        {
                            Console.WriteLine("Ingrese el salario semanal:");
                            string? salarioSemanalStr = Console.ReadLine();
                            if (decimal.TryParse(salarioSemanalStr, out decimal salarioSemanal))
                            {
                                EmpleadoAsalariado nuevoEmpleado = new EmpleadoAsalariado(primerNombre, apellidoPaterno, seguroSocial, salarioSemanal);
                                empleados.Add(nuevoEmpleado);
                            }
                            else
                            {
                                Console.WriteLine("Salario semanal inválido.");
                            }
                        }
                        else if (tipoEmpleado == 2)
                        {
                            Console.WriteLine("Ingrese el sueldo por hora:");
                            string? sueldoStr = Console.ReadLine();
                            if (decimal.TryParse(sueldoStr, out decimal sueldo))
                            {
                                Console.WriteLine("Ingrese las horas trabajadas:");
                                string? horasStr = Console.ReadLine();
                                if (decimal.TryParse(horasStr, out decimal horas))
                                {
                                    EmpleadoPorHoras nuevoEmpleado = new EmpleadoPorHoras(primerNombre, apellidoPaterno, seguroSocial, sueldo, horas);
                                    empleados.Add(nuevoEmpleado);
                                }
                                else
                                {
                                    Console.WriteLine("Horas trabajadas inválidas.");
                                }
                            } 
                            else
                            {
                                Console.WriteLine("Sueldo por hora inválido.");
                            }
                        }

                        GuardarEmpleadoEnArchivo();
                    }
                    else
                    {
                        Console.WriteLine("Los datos del empleado no pueden estar vacíos.");
                    }
                }
                else
                {
                    Console.WriteLine("Tipo de empleado inválido.");
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Estas saliendo del modo de ingresar datos nuevos \n");
                Console.WriteLine("Ingrese el nombre del empleado que desea buscar:");
                string? nombreBuscado = Console.ReadLine();
                if (!string.IsNullOrEmpty(nombreBuscado))
                {
                    BuscarEmpleadoPorNombre(nombreBuscado);
                }
                else
                {
                    Console.WriteLine("El nombre del empleado no puede estar vacío.");
                }
            }
        }

        static void BuscarEmpleadoPorNombre(string nombre)
        {
             string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Empleados", "NEmpleados.txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("El archivo NEmpleados.txt no existe.");
                return;
            }

            string[] lineas = File.ReadAllLines(filePath);
            bool encontrado = false;

            foreach (string linea in lineas)
            {
                if (linea.Contains(nombre))
                {
                    string[] datos = linea.Split(',');
                    Console.WriteLine("+----------------------+----------------------+----------------------+----------------------+");
                    Console.WriteLine("| Primer Nombre        | Apellido Paterno     | Seguro Social        | Información Adicional|");
                    Console.WriteLine("+----------------------+----------------------+----------------------+----------------------+");
                    Console.WriteLine($"| {datos[0],-20} | {datos[1],-20} | {datos[2],-20} | {datos[3],-20} |");
                    Console.WriteLine("+----------------------+----------------------+----------------------+----------------------+");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

       static void GuardarEmpleadoEnArchivo()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Empleados");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string filePath = Path.Combine(folderPath, "NEmpleados.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var empleado in empleados)
                {
                    writer.WriteLine(empleado.ToString());
                    writer.WriteLine($"Ingresos: {empleado.Ingresos():C}");
                    writer.WriteLine();
                }
            }
        }

        public abstract class Empleado
        {
            public string PrimerNombre { get; set; }
            public string ApellidoPaterno { get; set; }
            public string NumeroSeguroSocial { get; set; }

            public Empleado(string primernombre, string apellidopaterno, string segurosocial)
            {
                PrimerNombre = primernombre;
                ApellidoPaterno = apellidopaterno;
                NumeroSeguroSocial = segurosocial;
            }

            public abstract decimal Ingresos();
            public override string ToString() => $"{PrimerNombre},{ApellidoPaterno},{NumeroSeguroSocial}";
        
        }
        

        public class EmpleadoAsalariado : Empleado
        {
            public decimal SalarioSemanal { get; set; }
             public decimal comision {get; set;}
            public decimal comisionmas {get; set;}

            public EmpleadoAsalariado(string primernombre, string apellidopaterno, string segurosocial, decimal salarioSemanal)
                : base(primernombre, apellidopaterno, segurosocial)
            {
                SalarioSemanal = salarioSemanal;
            }

            public override decimal Ingresos() => SalarioSemanal;
            public override string ToString() => $"{base.ToString()},{SalarioSemanal:C}";
        }
      
        public class EmpleadoPorHoras : Empleado
        {
            public decimal Sueldo { get; set; }
            public decimal Horas { get; set; }
            public decimal comision {get; set;}
            public decimal comisionmas {get; set;}

            public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string segurosocial, decimal sueldo, decimal horas)
                : base(primerNombre, apellidoPaterno, segurosocial)
            {
                Sueldo = sueldo;
                Horas = horas;
            }

            public override decimal Ingresos() => Horas <= 40 ? Sueldo * Horas : (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
            public override string ToString() => $"{base.ToString()},{Sueldo:C},{Horas:F2}";
        }

       

    }
}
