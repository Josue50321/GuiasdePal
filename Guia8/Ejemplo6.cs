using System;

class Program
{
    static void Main()
    {
        // Programa realizado por
        // Día: Marzo 13, 2023

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Super Selectos - Precios usando arreglos";

        Console.Write("\nGuía #8 Ejemplo 6");
        Console.WriteLine("\n");

        double[] precios = new double[5];
        double total = 0;

        for (int i = 0; i < precios.Length; i++)
        {
            Console.Write("\tIngresa el precio del producto [" + (i + 1) + "]: $");
            while (!double.TryParse(Console.ReadLine(), out precios[i]) || precios[i] < 0)
            {
                Console.Write("\tValor inválido. Ingresa un precio válido: $");
            }
            total += precios[i];
        }

        Console.WriteLine("\n\tDetalle de la compra:");
        for (int i = 0; i < precios.Length; i++)
        {
            Console.WriteLine("\tProducto [" + (i + 1) + "]: $" + precios[i]);
        }

        Console.WriteLine("\n\tPrecio total: $" + Math.Round(total, 2));
        Console.Write("\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\t*                                         *");
        Console.WriteLine("\t*    Este programa fue diseñado por:     *");
        Console.WriteLine("\t*                                         *");
        Console.WriteLine("\t*            Juan Menjívar                *");
        Console.WriteLine("\t*                                         *");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}