
        int meses = 9;
        double[] ventas = new double[meses];

        for (int i = 0; i < meses; i++)
        {
            Console.Write($"Ingrese las ventas del mes {i + 1}: ");
            ventas[i] = double.Parse(Console.ReadLine());
        }

        /* Se calcula la venta mayor, menor y el promedio*/
        double mayorVenta = ventas[0];
        double menorVenta = ventas[0];
        double totalVentas = 0;

        for (int i = 0; i < meses; i++)
        {
            if (ventas[i] > mayorVenta)
                mayorVenta = ventas[i];
            if (ventas[i] < menorVenta)
                menorVenta = ventas[i];
            totalVentas += ventas[i];
        }

        double promedio = totalVentas / meses;

        /* Se encuentra los meses con ventas menores al promedio */
        Console.WriteLine("Meses con ventas menores al promedio:");

        for (int i = 0; i < meses; i++)
        {
            if (ventas[i] < promedio)
            {
                Console.WriteLine($"Mes {i + 1}: {ventas[i]}");
            }
        }

        /*Resultado*/
        Console.WriteLine($"Venta mayor: {mayorVenta}");
        Console.WriteLine($"Venta menor: {menorVenta}");
        Console.WriteLine($"Promedio de ventas: {promedio}");
    