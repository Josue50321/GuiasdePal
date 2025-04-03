
        /* Declaración de variables*/
        string nombre; /* Es texto*/
        int edad;
        int mayores = 0; /* Podriamos hacerlo tipo string si quisieramos que se leyera como texto*/

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Ingresa los datos de la persona {i}:");

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());

            /* Condicion si es mayor de edad*/
            if (edad >= 18)
            {
                Console.WriteLine($"{nombre} es mayor de edad.");
                mayores++;
            }
        }

        Console.WriteLine($"Total de personas mayores de edad: {mayores}");