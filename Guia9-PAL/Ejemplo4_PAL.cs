
        // Programa realizado por  
        // Día: Marzo 20, 2023 

        Console.WindowHeight = 45; // alto de la ventana
        Console.WindowWidth = 60;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "El inicio de un juego divertido...";

        Console.Write("\nGuia#9 Ejemplo4");
        Console.WriteLine("\n");

        int f, c;
        int[,] M = new int[3, 3]; // Matriz 3x3

        // Primera parte: Digitando la matriz
        Console.Write("\tDigitamos la matriz");
        Console.Write("\n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("\tIngrese el elemento [" + i + "," + j + "]: ");
                M[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Mostramos la matriz
        Console.WriteLine("\n");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("\t\t");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(M[i, j] + " ");
            }
            Console.WriteLine("\n");
        }

        // Segunda parte: Ingresar la posición a eliminar (poner 0)
        Console.WriteLine("\tIngrese la posición del alumno a eliminar");
        Console.Write("\tIngresa fila    : ");

        Console.ForegroundColor = ConsoleColor.Blue;
        f = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Write("\tIngresa columna : ");

        Console.ForegroundColor = ConsoleColor.Red;
        c = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Black;

        // Eliminamos el valor (poniéndolo en 0)
        M[f, c] = 0;

        Console.WriteLine("\n");

        // Mostramos la matriz después de la eliminación
        for (int i = 0; i < 3; i++)
        {
            Console.Write("\t\t");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(M[i, j] + " ");
            }
            Console.WriteLine("\n");
        }

        // Fin del programa
        Console.WriteLine("\t--> Fin del Programa");
        Console.ReadKey();

