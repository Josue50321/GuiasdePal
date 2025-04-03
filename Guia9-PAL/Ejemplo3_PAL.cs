
        // Programa realizado por  
        // Día: Marzo 20, 2023 

        Console.WindowHeight = 45; // alto de la ventana 
        Console.WindowWidth = 80;  // ancho de la ventana 
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Manejo de matrices y vectores para pagos de empleados";

        Console.Write("\nGuia#9 Ejemplo3");
        Console.WriteLine("\n");

        // Declaración de variables
        String[] empleados = new String[4];
        int[,] sueldos = new int[4, 3];
        int[] sueldostot = new int[4];
        int x = empleados.Length; // número de empleados

        // Primera Parte: Ingreso de datos
        for (int f = 0; f < x; f++)
        {
            Console.Write("\tIngrese el nombre del operario " + (f + 1) + ": ");
            empleados[f] = Console.ReadLine();

            int y = sueldos.GetLength(1);  // devuelve el tamaño de la columna
            for (int c = 0; c < y; c++)
            {
                Console.Write("\tIngrese sueldo " + (c + 1) + ": ");
                sueldos[f, c] = int.Parse(Console.ReadLine());
            }
        }

        // Segunda Parte: Cálculo del total de sueldos por operario
        int z = sueldos.GetLength(0);  // devuelve el tamaño de la fila
        for (int f = 0; f < z; f++)
        {
            int suma = 0;
            int e = sueldos.GetLength(1); // número de columnas de sueldos
            for (int c = 0; c < e; c++)
            {
                suma = suma + sueldos[f, c];
            }
            sueldostot[f] = suma;
        }

        // Tercera Parte: Mostrar estadísticas de sueldos
        Console.WriteLine("\n");
        Console.WriteLine("\t-----Estadística de Sueldos-----");
        Console.WriteLine("\tTotal de sueldos pagados por Operario.");

        for (int f = 0; f < sueldostot.Length; f++)
        {
            Console.WriteLine("\t" + empleados[f] + " -> " + "\t $" + sueldostot[f]);
        }

        // Cuarta Parte: Determinar el operario con el mayor sueldo
        int may = sueldostot[0];
        String nom = empleados[0];

        for (int f = 0; f < sueldostot.Length; f++)
        {
            if (sueldostot[f] > may)
            {
                may = sueldostot[f];
                nom = empleados[f];
            }
        }

        Console.Write("\tEl operario con mayor sueldo es " + nom + " con un valor de $" + may);
        Console.WriteLine("\n\n");
        Console.WriteLine("\t--> Fin del Programa");
        Console.Write("\t");

