
        // Configuración inicial de la consola
        Console.WindowHeight = 25; // alto de la ventana
        Console.WindowWidth = 60;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Cantidad de n piezas con DoWhile";
        Console.Write("\n\tGuia#6 Ejemplo6");

        // Declaración de variables
        int x, cantidad, n;
        double largo;
        x = 1;
        cantidad = 0;

        // Entrada de datos
        Console.Write("\n\tCuantas piezas va a digitar...: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        // Proceso con DoWhile
        do
        {
            Console.Write("\tIngrese la medida de la pieza.: ");
            largo = double.Parse(Console.ReadLine());

            if (largo >= 1.2 && largo <= 1.3)
            {
                cantidad = cantidad + 1;
            }

            x = x + 1;
        } while (x <= n);

        // Salida
        Console.WriteLine("\n\tResultados....");
        Console.Write("\tLa cantidad de piezas aptas son: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(cantidad);
        Console.ForegroundColor = ConsoleColor.Black;

        // Pantalla opcional
        Console.WriteLine("\n");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("*********************************************");
        Console.Write("\n");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("\t* *");
        Console.WriteLine("\t* Este programa fue diseñado por: *");
        Console.WriteLine("\t* *");
        Console.WriteLine("\t* Tu Nombre *");
        Console.WriteLine("\t* *");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("\n\t");
        Console.ReadKey();
