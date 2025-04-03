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
        Console.Title = "El número mayor y menor en un vector";

        Console.Write("\nGuía #8 Ejemplo 3");
        Console.WriteLine("\n");

        int tam;
        double menor, mayor;

        Console.Write("\tDame el tamaño del vector: ");
        Console.ForegroundColor = ConsoleColor.Red;
        tam = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;

        double[] n = new double[tam];
        Console.WriteLine("\n");

        // Digitamos los datos del vector
        for (int i = 0; i < tam; i++)
        {
            Console.Write("\tDigite el elemento [" + i + "] : ");
            n[i] = double.Parse(Console.ReadLine());
        }

        // Encontrar el mayor y el menor
        mayor = n[0];
        menor = n[0];
        int p1 = 0, p2 = 0;

        for (int i = 0; i < tam; i++)
        {
            if (n[i] > mayor)
            {
                mayor = n[i];
                p1 = i;
            }
            else if (n[i] < menor)
            {
                menor = n[i];
                p2 = i;
            }
        }

        Console.WriteLine("\n");
        Console.Write("\tEl número mayor del vector es: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(mayor);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(" y está en la posición ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[" + p1 + "]");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n");

        Console.Write("\tEl número menor del vector es: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(menor);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(" y está en la posición ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[" + p2 + "]");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\n");

        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}