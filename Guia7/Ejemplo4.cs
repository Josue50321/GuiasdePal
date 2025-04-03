using System;

namespace Guia7ejemplo3
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
            Console.Title = "Conversión de monedas usando Funciones";

            Console.Write("\nGuia#7 Ejemplo3\n");

            double x, p, r;

            Console.Write("\tDigitar la cantidad en dólares: $ ");
            Console.ForegroundColor = ConsoleColor.Red;
            x = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");

            // Llamadas a las funciones
            p = euros(x);
            Console.Write("\tLos ${0} dolares son {1} euros", x, p);
            Console.WriteLine("\n");

            r = libras(x);
            Console.Write("\tLos ${0} dolares son {1} libras", x, r);
            Console.WriteLine("\n\n");

            Programador(); // Procedimiento sin parámetro
            Console.ReadKey();
        }

        static double euros(double a)
        {
            double g;
            g = a * 1.15;
            return g;
        }

        static double libras(double a)
        {
            double v;
            v = a * 3.15;
            return v;
        }

        static void Programador()
        {
            // Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*            B O N   J O V I                *");
            Console.WriteLine("\t*                                           *");

            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Green;
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
