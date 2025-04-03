
        // Configuración inicial de la consola
        Console.WindowHeight = 35; // alto de la ventana
        Console.WindowWidth = 65;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Total de sueldos de trabajadores";
        Console.Write("\n\tGuia#6 Ejemplo7");
        Console.WriteLine("\n");

        // Declaración de variables
        int op, i, cantidad;
        string nombre, ocupacion;
        double sueldo;
        double total = 0;

        // Entrada y procesos de datos
        do
        {
            Console.Clear();
            Console.Write("\tCuantos empleados va a registrar? : ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (i = 1; i <= cantidad; i++)
            {
                Console.Write("\tIngrese el nombre del empleado[{0}]: ", i);
                nombre = Console.ReadLine();
                Console.Write("\tIngrese la ocupacion del empleado: ");
                ocupacion = Console.ReadLine();
                Console.Write("\tIngrese el sueldo: $ ");
                Console.ForegroundColor = ConsoleColor.Blue;
                sueldo = Double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
                total += sueldo;
                Console.WriteLine("\n");
            }

            Console.Write("\tEl total de dinero invertido en sueldos es: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("$ " + total);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.Write("\tSi desea continuar, presione 1 sino presione 0: ");
            op = int.Parse(Console.ReadLine());
        } while (op == 1);

        // Pantalla opcional
        Console.WriteLine("\n\n");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("*********************************************");
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
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.WriteLine("--> Fin del Programa");
        Console.Write("\t");
        Console.ReadKey();
