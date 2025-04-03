using System;

class Program
{
    static void Main()
    {
        // Programa realizado por
        // Día: Marzo 13, 2023

        Console.WindowHeight = 35; // Alto de la ventana
        Console.WindowWidth = 65;  // Ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Como inicializar un vector con datos, uso de Length";

        Console.Write("\nGuía#8 Ejemplo 2");
        Console.WriteLine("\n");

        // Declaración de variables
        double sumaNotas = 0, promedio;
        int i;

        // Asignación de valores a los vectores
        double[] notas = { 10, 7.2, 8.5, 9.1, 6.5 };
        string[] alumnos = { "Juan", "Toño", "Chepe", "Rodrigo", "Marisol" };

        // Verificación de los datos en cada vector
        // La instrucción notas.Length permite saber el tamaño del vector notas
        for (i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("\n\tLa nota de {0} es \t: {1}", alumnos[i], notas[i]);
        }

        // Sumar todas las notas
        for (i = 0; i < notas.Length; i++)
        {
            sumaNotas += notas[i];
        }

        // Cálculo del promedio
        promedio = sumaNotas / notas.Length;

        Console.WriteLine("\n\t-----------------------------------------");
        Console.Write("\n\tLa suma de todas las notas es \t: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(sumaNotas);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("\n\tEl promedio de las notas es \t: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Math.Round(promedio, 2));
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\n\n");
        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}