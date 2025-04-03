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
        Console.Title = "Programa que posee el método de la burbuja";

        Console.Write("\nGuía #8 Ejemplo 4");
        Console.WriteLine("\n");

        double[] ventas = new double[5];
        int i, j;
        double encontrado, promedio, suma, buscar, mayor, menor, aux;
        bool resp = false;

        // LLENADO DE VENTAS
        for (i = 0; i < 5; i++)
        {
            Console.Write("\tPosición número " + i + " de las ventas = $");
            ventas[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n");

        // IMPRIME LOS DATOS AÑADIDOS
        for (i = 0; i < 5; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t" + ventas[i]);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        Console.WriteLine("\n");

        // BUSCAR UNA VENTA
        encontrado = 1;
        Console.Write("\n\tDigitar la venta a buscar: $");
        buscar = double.Parse(Console.ReadLine());

        for (i = 0; i < 5; i++)
        {
            if (buscar == ventas[i])
            {
                resp = true;
                break;
            }
        }

        if (resp)
        {
            Console.WriteLine("\n\tLa venta ${0} fue encontrada", buscar);
        }
        else
        {
            Console.WriteLine("\n\tLa venta ${0} no fue encontrada", buscar);
        }

        // MOSTRAR LA MAYOR Y LA MENOR VENTA
        mayor = ventas[0];
        menor = ventas[0];

        for (i = 0; i < 5; i++)
        {
            if (ventas[i] > mayor)
                mayor = ventas[i];

            if (ventas[i] < menor)
                menor = ventas[i];
        }

        Console.WriteLine("\n\tLa mayor venta es\t: $" + mayor);
        Console.WriteLine("\n\tLa menor venta es\t: $" + menor);

        // SUMA DE LAS VENTAS
        suma = 0;
        for (i = 0; i < 5; i++)
        {
            suma += ventas[i];
        }

        Console.WriteLine("\n\tLa suma de las ventas es\t: $" + suma);
        promedio = suma / 5;
        Console.WriteLine("\n\tEl promedio de las ventas es\t: $" + Math.Round(promedio, 2));

        // ORDENACIÓN POR MÉTODO DE LA BURBUJA
        for (i = 0; i < 5 - 1; i++)
        {
            for (j = 0; j < 5 - 1 - i; j++)
            {
                if (ventas[j] > ventas[j + 1])
                {
                    aux = ventas[j];
                    ventas[j] = ventas[j + 1];
                    ventas[j + 1] = aux;
                }
            }
        }

        // IMPRIME LAS VENTAS ORDENADAS
        Console.WriteLine("\n\tEl vector ordenado queda así:");
        Console.WriteLine("\n");

        for (i = 0; i < 5; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\t $" + ventas[i]);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("\n\tPresione ENTER para terminar");
        Console.ReadKey();
    }
}