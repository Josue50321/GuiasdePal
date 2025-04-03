using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Programa realizado por  
        // Día: Marzo 20, 2023 

        Console.WindowHeight = 35; // alto de la ventana 
        Console.WindowWidth = 65; // ancho de la ventana 
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Sumando los datos de 2 matrices de tamaño 2x3";

        Console.Write("\nGuia#9 Ejemplo2");
        Console.WriteLine("\n");

        // Declarando las matrices 
        int[,] Matriz1 = new int[2, 3];
        int[,] Matriz2 = new int[2, 3];
        int[,] Matriz3 = new int[2, 3];

        // Digitamos la primer matriz 
        Console.Write("\tDigitamos la primer matriz [1]");
        Console.Write("\n");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("\tIngrese el elemento [" + i + "," + j + "]: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Matriz1[i, j] = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        Console.Write("\n");

        // Digitamos la segunda matriz 
        Console.Write("\tDigitamos la segunda matriz [2]");
        Console.Write("\n");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("\tIngrese el elemento [" + i + "," + j + "]: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Matriz2[i, j] = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        Console.Write("\n");

        // Realizamos el cálculo de la suma de las 2 matrices 
        Console.Write("\tSumando las 2 matrices anteriores");
        Console.Write("\n");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Matriz3[i, j] = Matriz1[i, j] + Matriz2[i, j];
            }
        }

        // Llamamos a un procedimiento para visualizar el resultado 
        Mostrar(Matriz3);

        Console.WriteLine("\n");
        Console.WriteLine("\t--> Fin del Programa");
        Console.ReadKey();
    }

    // Procedimiento para mostrar la matriz resultante
    static void Mostrar(int[,] Matriz3)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < 3; j++)
            {
                Console.Write("\t" + Matriz3[i, j]);
            }
        }
    }
}
