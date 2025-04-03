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
        Console.Title = "Ferretería - Tornillo Suelto pero Baratus";

        Console.Write("\nGuía #8 Ejemplo 8");
        Console.WriteLine("\n");

        int num, cantidad;
        double total = 0.0;

        Console.Write("\t¿Cuántos productos va a facturar? ");

        while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
        {
            Console.Write("\tIngrese una cantidad válida de productos: ");
        }

        string[] producto = new string[num];
        double[] precio = new double[num];

        for (int a = 0; a < num; a++)
        {
            Console.WriteLine($"\tIngrese el nombre del {a + 1}° producto");
            Console.Write("\t");
            producto[a] = Console.ReadLine();

            Console.WriteLine($"\t¿Cuál es el precio unitario de {producto[a]}?");
            Console.Write("\t");

            while (!double.TryParse(Console.ReadLine(), out precio[a]) || precio[a] < 0)
            {
                Console.Write("\tIngrese un precio válido: ");
            }

            Console.WriteLine($"\tCantidad que compró de {producto[a]}");
            Console.Write("\t");

            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("\tIngrese una cantidad válida: ");
            }

            precio[a] *= cantidad;
            total += precio[a];
        }

        Console.WriteLine("\n\tPresione ENTER para aceptar la compra");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("\t===========================================");
        Console.WriteLine("\t======= Detalle de Factura ========");
        Console.Write("\n");

        for (int a = 0; a < num; a++)
        {
            Console.WriteLine($"\t {producto[a]} -----> ${precio[a]:F2}");
        }

        Console.Write("\n");
        Console.WriteLine("\t===========================================");
        Console.WriteLine($"\tTotal a Pagar ============> ${total:F2}");
        Console.Write("\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\t*                                         *");
        Console.WriteLine("\t*    Este programa fue diseñado por:     *");
        Console.WriteLine("\t*                                         *");
        Console.WriteLine("\t*             Gloria Díaz                *");
        Console.WriteLine("\t*                                         *");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}