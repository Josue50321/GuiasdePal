
        // Establecemos los parámetros de la consola
        Console.Title = "Guia9 Ejemplo5 Jueguito X 0";
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

        // Declaración de variables
        int f, c;
        int a = 0, g;
        string[,] M = new string[3, 3];

        // Mensaje de bienvenida
        Console.Write("\nJueguito del X - 0");
        Console.Write("\n");

        // Entrada de datos: se llena la matriz 3x3
        Console.Write("Digitamos la matriz [3x3] ");
        Console.Write("\n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Ingrese el elemento [" + i + "," + j + "]: ");
                M[i, j] = Console.ReadLine();
            }
        }

        // Visualización de la matriz ingresada
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

        // Bucle para el juego, eliminando o colocando "X"
        int op1;
        do
        {
            Console.Clear();
            a = a + 1; // Alterna entre 0 y 1

            // Solicitar la posición para eliminar o colocar "X"
            Console.WriteLine("Ingrese la posición del alumno a eliminar");
            Console.Write("Ingresa fila: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Ingresa columna: ");
            c = int.Parse(Console.ReadLine());

            g = a % 2; // Alterna entre 0 y 1

            if (g == 1)
            {
                // Coloca un "0" en la matriz
                Console.ForegroundColor = ConsoleColor.Blue;
                M[f, c] = "0";
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");

                // Imprime la matriz actualizada
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\t\t");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(M[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                // Coloca una "X" en la matriz
                Console.ForegroundColor = ConsoleColor.Red;
                M[f, c] = "X";
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");

                // Imprime la matriz actualizada
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\t\t");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(M[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }

            // Pregunta si se desea seguir jugando
            Console.Write("-->Si desea seguir jugando, digite 1 sino 0: ");
            op1 = int.Parse(Console.ReadLine());

        } while (op1 == 1); // El juego continúa mientras op1 sea igual a 1

        // Fin del programa
        Console.WriteLine("\t--> Fin del Programa");
        Console.ReadKey();
 