
        // Configuración inicial de la consola
        Console.WindowHeight = 30; // alto de la ventana
        Console.WindowWidth = 75;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Estadio el Manguito - Soyacity";
        Console.Write("\n\tGuia#6 Ejemplo9");

        // Declaración de variables
        int op2;
        int cantidad = 0;
        string op;
        double precio = 0, total = 0;

        // Entrada y Procesos de datos
        do
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t***************************************************");
            Console.WriteLine("\t* BIENVENIDO AL ESTADIO EL MANGUITO *");
            Console.WriteLine("\t***************************************************");
            Console.WriteLine("\t* *");
            Console.WriteLine("\t* SECTORES DEL ESTADIO *");
            Console.WriteLine("\t* *");
            Console.WriteLine("\t* A- SOL CANDENTE $3 *");
            Console.WriteLine("\t* B- SOL LUMINOSO $5 *");
            Console.WriteLine("\t* C- SOMBRITA $8 *");
            Console.WriteLine("\t* D- TRIBUNITA $15 *");
            Console.WriteLine("\t* E- SILLA PLASTICA $20 *");
            Console.WriteLine("\t* *");
            Console.WriteLine("\t*********************");
            Console.Write("\tSelecciona la letra del sector del estadio: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            op = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");

            switch (op)
            {
                case "A":
                case "a":
                    Console.WriteLine("\tSector seleccionado...: Sol Candente");
                    Console.Write("\tCantidad de entradas..: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    cantidad = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    precio = 3;
                    break;

                case "B":
                case "b":
                    Console.WriteLine("\tSector seleccionado...: Sol Luminoso");
                    Console.Write("\tCantidad de entradas..: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    cantidad = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    precio = 5;
                    break;

                case "C":
                case "c":
                    Console.WriteLine("\tSector seleccionado...: Sombrita");
                    Console.Write("\tCantidad de entradas..: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    cantidad = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    precio = 8;
                    break;

                case "D":
                case "d":
                    Console.WriteLine("\tSector seleccionado...: Tribunita");
                    Console.Write("\tCantidad de entradas..: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    cantidad = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    precio = 15;
                    break;

                case "E":
                case "e":
                    Console.WriteLine("\tSector seleccionado...: Silla Plástica");
                    Console.Write("\tCantidad de entradas..: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    cantidad = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    precio = 20;
                    break;

                default:
                    Console.WriteLine("\tERROR: El sector seleccionado no existe");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }

            total = precio * cantidad;
            Console.WriteLine("\tPrecio Unitario.......: $" + precio);
            Console.WriteLine("\tTotal a pagar.........: $" + total);
            Console.WriteLine("\n");
            Console.WriteLine("\tGracias por visitar el Manguito!");
            Console.WriteLine("\n\n");

            Console.Write("\tSi desea continuar presione 1, sino 0 para salirse: ");
            op2 = int.Parse(Console.ReadLine());
        } while (op2 != 0);

        // Pantalla opcional
        Console.Clear();
        Console.WriteLine("\n");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Magenta;
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
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*********************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.WriteLine("--> Fin del Programa");
        Console.Write("\t");
        Console.ReadKey();
  