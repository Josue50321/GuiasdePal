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
        Console.Title = "Biblioteca Soyacity - Lo mejor en books";

        Console.Write("\nGuía #8 Ejemplo 7");
        Console.WriteLine("\n");

        int n;
        Console.Write("\t¿Cuántos libros desea registrar? ");

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("\tIngrese un número válido de libros: ");
        }

        // Declaración de arreglos
        string[] libros = new string[n];
        string[] autores = new string[n];

        Console.WriteLine("\n\tIngrese la siguiente información de los libros");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\t******* Nombre del Libro {i + 1} *******");
            Console.Write("\t");
            libros[i] = Console.ReadLine();

            Console.WriteLine($"\t******* Autor del Libro {i + 1} *******");
            Console.Write("\t");
            autores[i] = Console.ReadLine();
        }

        Console.WriteLine("\n\tInformación sobre los libros");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\tLibro {i + 1}. {libros[i]} - Autor(es): {autores[i]}");
        }

        Console.Write("\n\tHasta Luego . . . \n");
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\t*                                         *");
        Console.WriteLine("\t*    Este programa fue diseñado por:     *");
        Console.WriteLine("\t*                                         *");
        Console.WriteLine("\t*             Gloria Díaz                *");
        Console.WriteLine("\t*                                         *");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}