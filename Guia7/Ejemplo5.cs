using System;
using System.Threading; // Librería necesaria

namespace Guia7ejemplo5
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: Marzo 6, 2023
            Console.WindowHeight = 25;  // Alto de la ventana            
            Console.WindowWidth = 68;   // Ancho de la ventana 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Procedimiento sin parámetros en un menú";

            int opcion, i;

            Console.WriteLine("\n\t----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t   MENU PRINCIPAL DE TIPOS DE PAGOS");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.WriteLine("\t  [1] Efectivo\t\t\t15%");
            Console.WriteLine("\t  [2] Tarjeta de Credito\t10%");
            Console.WriteLine("\t  [3] Cheque\t\t\t5%");
            Console.WriteLine("\t  [4] Tarjeta de Regalo\t\t20%");
            Console.WriteLine("\n\t----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tDigitar la opción deseada (1..4): ");
            Console.ForegroundColor = ConsoleColor.Black;

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    efectivo();
                    break;
                case 2:
                    credito();
                    break;
                case 3:
                    cheque();
                    break;
                case 4:
                    regalo();
                    break;
                default:
                    Console.WriteLine("\nSe ha equivocado de opción, solo acepta [1..4]");
                    break;
            }

            Console.WriteLine("\n");
            Console.Write("\t--> Fin del programa, presiona Enter para continuar <--");
            Console.ReadKey();
            Console.Clear();

            Console.Write("\tA T E N C I O N");
            Console.Write("\n\n\tEste programa se destruirá en: ");
            for (i = 3; i >= 0; i--)
            {
                Console.Write("\n\t{0} segundos ", i);
                Thread.Sleep(1000);
                Console.Beep();
            }
            Environment.Exit(0);
            Console.ReadKey();
        }

        static void efectivo()
        {
            double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.15;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }

        static void credito()
        {
            double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.10;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }

        static void cheque()
        {
            double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.05;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }

        static void regalo()
        {
            double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.20;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }
    }
}
