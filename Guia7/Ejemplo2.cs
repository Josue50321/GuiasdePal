using System;

namespace Guia7ejemplo2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: Marzo 6, 2023
            Console.WindowHeight = 25;  // Alto de la ventana            
            Console.WindowWidth = 60;   // Ancho de la ventana 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Suma y Resta con procedimientos sin parametros";
            Console.Write("\nGuia#7 Ejemplo2");
            Console.WriteLine("\n");

            suma();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            resta();
            Console.WriteLine("\n\n");

            Programador(); // Procedimiento sin parámetro
            Console.ReadKey();
        }

        static void suma()
        {
            Double r, n1, n2;
            Console.Write("\tDigitar la primera cantidad: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar la segunda cantidad: ");
            n2 = Double.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tEl resultado de la suma es: " + r);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void resta()
        {
            Double r, n1, n2;
            Console.Write("\tDigitar la primera cantidad: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar la segunda cantidad: ");
            n2 = Double.Parse(Console.ReadLine());
            r = n1 - n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tEl resultado de la resta es: " + r);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Programador()
        {
            // Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*            I R O N   M A I D E N          *");
            Console.WriteLine("\t*                                           *");

            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
        }
    }
}

