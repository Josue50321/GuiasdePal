  /* Crear un arreglo de temperaturas de 7 ya  que son 7 dias */
        double[] temperaturas = new double[7];

        /*  Pedimos las 7 temperaturas*/
        Console.WriteLine("Ingrese las temperaturas de la ciudad para cada uno de los 7 días de la semana:");

        int contador = 0;
        while (contador < 7)
        {
            Console.Write($"Día {contador + 1}: ");
            temperaturas[contador] = double.Parse(Console.ReadLine());
            contador++;
        }

        /* Buscar la temperatura mayor y menor con un solo bucle*/
        double maxTemp = temperaturas[0], minTemp = temperaturas[0];

        foreach (double temp in temperaturas)
        {
            if (temp > maxTemp)
                maxTemp = temp;

            if (temp < minTemp)
                minTemp = temp;
        }

        Console.WriteLine($"\nLa temperatura mayor de la semana es: {maxTemp}°C");
        Console.WriteLine($"La temperatura menor de la semana es: {minTemp}°C");
