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
        Console.Title = "Ejemplo de vectores con letras";

        Console.Write("\nGuía #8 Ejemplo 5");
        Console.WriteLine("\n");

        // Escriba un programa que lea una cadena de texto y como resultado 
        // muestre el total de vocales y espacios en blanco que tiene la frase.

        string nombre;
        char caracter;
        int vocales = 0, espacios = 0;

        Console.Write("\n\tIntroduzca una frase: ");
        nombre = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("\tEl tamaño de la oración es de " + nombre.Length + " caracteres");
        Console.WriteLine("\n");
        Console.WriteLine("\t-------------------------------------------------");

        foreach (char c in nombre)
        {
            caracter = char.ToLower(c); // Convertir todo a minúsculas para simplificar comparaciones

            if (caracter == ' ')
                espacios++;

            if ("aeiou".Contains(caracter))
                vocales++;
        }

        Console.Write("\n\tEl total de espacios en blanco son ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(espacios);
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Write("\n\tEl total de vocales son ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine(vocales);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;

        Console.WriteLine("\n\n");
        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}