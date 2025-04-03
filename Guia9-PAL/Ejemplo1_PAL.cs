using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Programa realizado por  
        // Día: Marzo 20, 2023 

        // Configuración de la ventana de la consola
        Console.WindowHeight = 30; // alto de la ventana 
        Console.WindowWidth = 60;  // ancho de la ventana 
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Manejo de datos en una matriz [3x3]";

        // Título del programa
        Console.Write("\nGuia#9 Ejemplo1");
        Console.WriteLine("\n");

        // Declaración de la matriz 3x3
        int[,] Matrix = new int[3, 3];

        // Cargar y visualizar una matriz 
        for (int x = 0; x < 3; x++) // for externo para filas 
        {
            for (int y = 0; y < 3; y++) // for interno para columnas 
            {
                // Solicitar al usuario que ingrese un valor para cada posición de la matriz
                Console.Write("\tIngrese el valor de la posición [" + x + "," + y + "]: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Matrix[x, y] = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        // Imprimir la matriz ingresada
        Console.Write("\n");
        Console.Write("\tAhora visualizamos la matriz digitada....");
        Console.WriteLine("\n");
        Imprimir(Matrix);
        Console.WriteLine("\n\n");

        // Llamar al procedimiento para mostrar el programador
        Programador();

        // Esperar a que el usuario presione una tecla para cerrar
        Console.ReadKey();
    }

    // Método para imprimir la matriz
    static void Imprimir(int[,] Matrix)
    {
        for (int x = 0; x < 3; x++)
        {
            Console.Write("\n");
            for (int y = 0; y < 3; y++)
            {
                Console.Write("\t" + Matrix[x, y]);
            }
        }
    }

    // Procedimiento para mostrar información sobre el programador
    static void Programador()
    {
        // Pantalla opcional con la información del programador
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("\t*                                           *");
        Console.WriteLine("\t*     Este programa fue diseñado por:       *");
        Console.WriteLine("\t*                                           *");
        Console.WriteLine("\t*             Diego Maradona                *");
        Console.WriteLine("\t*                                           *");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.WriteLine("--> Fin del Programa");
        Console.Write("\t");
    }
}