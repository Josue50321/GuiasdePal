
        // Configuración inicial de la consola
        Console.WindowHeight = 20; // alto de la ventana
        Console.WindowWidth = 58;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "DoWhile, usando centinela con letra...";
        Console.Write("\n\tGuia#6 Ejemplo8");

        // Declaración de variables
        double x, y, suma;
        string resp;

        // Entrada y proceso
        do
        {
            Console.Clear();
            Console.Write("\n\tDigitar el primer número.....: ");
            x = Double.Parse(Console.ReadLine());

            Console.Write("\tDigitar el segundo numero....: ");
            y = Double.Parse(Console.ReadLine());

            suma = x + y;
            Console.Write("\n\tLa suma de ambos es..........: " + suma);
            Console.WriteLine("\n");

            Console.Write("\n\tDesea continuar (s/n): ");
            resp = Console.ReadLine();
        } while (resp != "n" && resp != "N"); // se sale cuando la condición es FALSA

        // Pantalla opcional
        Console.WriteLine("\n");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Blue;
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
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.ReadKey();

