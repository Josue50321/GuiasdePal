using System;

namespace Guia7ejemplo1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WindowHeight = 20;  // alto de la ventana            
            Console.WindowWidth = 60; // ancho de la ventana 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Numero par o impar usando procedimientos";

            Console.WriteLine("\n");

            int num;

            Console.Write("\tDigitar un numero entero positivo: ");
            num = int.Parse(Console.ReadLine());
            Par(num);  // procedimiento con parametro

            Console.WriteLine("\n\n");
            Programador(); // procedimiento sin parametro 

            Console.ReadKey();
        }

        static void Par(int a)
        {
            int x;
            x = (a % 2);
            if (x == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tEs par");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tEs impar");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        static void Programador()
        {
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*            M E T A L L I C A              *");
            Console.WriteLine("\t*                                           *");

            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Red;
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
