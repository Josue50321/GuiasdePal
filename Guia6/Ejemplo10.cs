
        // Configuración inicial de la consola
        Console.WindowHeight = 20; // alto de la ventana
        Console.WindowWidth = 75;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Title = "Menú Star Wars";
        Console.Write("\n\tGuia#6 Ejemplo10");

        // Declaración de variables
        ConsoleKeyInfo op;
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.WriteLine("\t\t\t\tMenú \n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t");
            Console.Write("[A] Agregar\t");
            Console.Write("[E] Eliminar\t");
            Console.Write("[B] Buscar\t");
            Console.Write("[Esc] Salir\t\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tPresione la tecla de su opción: ");
            op = Console.ReadKey(true); // No mostrar la tecla señalada

            // Acción según la tecla seleccionada
            switch (op.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\tUd seleccionó la opción Agregar");
                    Console.Write("\tPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case ConsoleKey.E:
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\tUd seleccionó la opción Eliminar");
                    Console.Write("\tPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case ConsoleKey.B:
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\tUd seleccionó la opción Buscar");
                    Console.Write("\tPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("\n\n");
                    Console.Write("\tChao");
                    Console.ReadKey();
                    break;
            }
        } while (op.Key != ConsoleKey.Escape);

        // Limpiar la pantalla y ajustar el tamaño de la ventana
        Console.Clear();
        Console.WindowWidth = 60; // ancho de la ventana
        Console.WriteLine("\n\n");

        // Pantalla opcional
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\t* *");
        Console.WriteLine("\t* Este programa fue diseñado por: *");
        Console.WriteLine("\t* *");
        Console.WriteLine("\t* Tu Nombre *");
        Console.WriteLine("\t* *");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("\t");
        Console.WriteLine("--> Fin del Programa");
        Console.Write("\t");
        Console.ReadKey();
