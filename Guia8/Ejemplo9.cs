using System;

namespace Comisiones
{
    class Program
    {
        static void Main()
        {
            // Programa realizado por
            // Día: Marzo 13, 2023

            Console.WindowHeight = 33; // alto de la ventana
            Console.WindowWidth = 60;  // ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Reporte de Comisiones en una Empresa";

            Console.Write("\nGuía #8 Ejemplo 9");
            Console.WriteLine("\n");

            // Declaración de variables
            const int EMPLEADOS = 3;
            string[] nombres = new string[EMPLEADOS];
            double[] ventas = new double[EMPLEADOS];
            double nivel;

            // Uso de procedimientos y funciones
            LeeNombres(nombres);
            LeeVentas(nombres, ventas);
            nivel = CalculaNivel(ventas);
            Imprime(nombres, ventas, nivel);

            Console.Write("\n\t");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t*                                         *");
            Console.WriteLine("\t*     Este programa fue diseñado por:     *");
            Console.WriteLine("\t*                                         *");
            Console.WriteLine("\t*           Bladimir Díaz                 *");
            Console.WriteLine("\t*                                         *");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();
        }

        public static void LeeNombres(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Digite el nombre del vendedor {0}: ", i + 1);
                nombres[i] = Console.ReadLine();
            }
        }

        public static void LeeVentas(string[] nombres, double[] ventas)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                double valor;
                bool valido;
                do
                {
                    Console.Write("Digite la venta de {0}: ", nombres[i]);
                    valido = double.TryParse(Console.ReadLine(), out valor) && valor >= 0;

                    if (!valido)
                    {
                        Console.WriteLine("Error: Ingrese un valor numérico válido y no negativo.");
                    }
                } while (!valido);

                ventas[i] = valor;
            }
        }

        public static double CalculaNivel(double[] ventas)
        {
            double nivel = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                nivel += ventas[i];
            }

            nivel = (nivel / ventas.Length) * 3 / 4.0;
            return nivel;
        }

        public static void Imprime(string[] nombres, double[] ventas, double nivel)
        {
            double ventaTotal = 0, comisionTotal = 0;

            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("\nReporte final de comisiones......");
            Console.Write("\n");
            Console.WriteLine("{0,-20}{1,15}{2,15}", "Nombre", "Venta", "Comisión");

            for (int i = 0; i < nombres.Length; i++)
            {
                double comi = 0;

                if (ventas[i] > nivel)
                {
                    comi = (ventas[i] - nivel) * 0.05; // Ajustado el cálculo de comisión
                }

                Console.WriteLine("{0,-20}{1,15:C2}{2,15:C2}", nombres[i], ventas[i], comi);
                comisionTotal += comi;
                ventaTotal += ventas[i];
            }

            Console.WriteLine("{0,-20}{1,15:C2}{2,15:C2}", "TOTAL.....", ventaTotal, comisionTotal);
        }
    }
}
