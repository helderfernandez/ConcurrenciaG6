using BenchmarkDotNet.Running;
using Preyecto1.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto1.consulaEvaluacionRendimiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Rendimiento operaciones calculo numerico 1");
                Console.WriteLine("2. Rendimiento operaciones calculo con base de datos 2");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción (1-3): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Rendimiento operaciones calculo numerico...");
                        BenchmarkRunner.Run<RNEntero>();
                        Console.WriteLine("Benchmark completado. Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Rendimiento operaciones calculo con base de datos...");
                        BenchmarkRunner.Run<RNEvaluarREndimiento>();
                        Console.WriteLine("Benchmark completado. Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del programa. Presiona cualquier tecla para cerrar.");
                        Console.ReadKey();
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Presiona cualquier tecla para intentar de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
