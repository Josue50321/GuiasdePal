
        // Configuración inicial de la consola
        Console.WindowHeight = 40; // alto de la ventana
        Console.WindowWidth = 80;  // ancho de la ventana
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Total de dinero y conversión de dólares";

        // Declaración de variables
        int salir = 0;
        int saliryesno;
        int cambiarmoneda;
        double total_bill1, total_bill5, total_bill10, total_bill20;
        double total_bill50, total_bill100;
        double total_cent1, total_cent5, total_cent10, total_cent25;
        double total_bill, total_cent, total_dinero, quetzal, lempira, euro;

        // Entrada y proceso
        while (salir == 0)
        {
            Console.Clear();

            // Entrada: cantidad de billetes
            Console.Write("\n\tCantidad de billetes de un dolar..........: $");
            total_bill1 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de billetes de cinco dolares.....: $");
            total_bill5 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de billetes de diez dolares......: $");
            total_bill10 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de billetes de veinte dolares....: $");
            total_bill20 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de billetes de cincuenta dolares.: $");
            total_bill50 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de billetes de cien dolares......: $");
            total_bill100 = double.Parse(Console.ReadLine());

            // Procesamiento de los billetes
            total_bill = (total_bill1 * 1) + (total_bill5 * 5) + (total_bill10 * 10) + (total_bill20 * 20) +
                         (total_bill50 * 50) + (total_bill100 * 100);

            // Entrada: cantidad de monedas
            Console.Write("\n\tCantidad de monedas de un centavo.........: ");
            total_cent1 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de monedas de cinco centavos.....: ");
            total_cent5 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de monedas de diez centavos......: ");
            total_cent10 = double.Parse(Console.ReadLine());
            Console.Write("\n\tCantidad de monedas de veinticinco........: ");
            total_cent25 = double.Parse(Console.ReadLine());

            // Procesamiento de las monedas
            total_cent = (total_cent1 * 0.01) + (total_cent5 * 0.05) + (total_cent10 * 0.10) + (total_cent25 * 0.25);

            // Salidas: total en billetes, total en monedas y total dinero
            Console.Write("\n\tLa cantidad de dinero que hay en billetes es: $" + total_bill);
            Console.Write("\n\tLa cantidad de dinero que hay en monedas es : $" + total_cent);
            total_dinero = total_bill + total_cent;
            Console.Write("\n\tLa cantidad total de dinero que hay es : $" + total_dinero);

            // Conversión de dólares
            Console.Write("\n\n\tCONVERSION DE MONEDAS");
            Console.Write("\n\n\tMoneda\t\tCodigo\n");
            Console.Write("\tQuetzal\t\t 1\n");
            Console.Write("\tLempira\t\t 2\n");
            Console.Write("\tEuro\t\t 3\n\n");

            Console.Write("\n\tIntroduzca el código de la moneda a la que desea convertir los $: ");
            cambiarmoneda = int.Parse(Console.ReadLine());

            // Cálculos de conversión
            quetzal = total_dinero * 7.95270;
            lempira = total_dinero * 19.71674;
            euro = total_dinero * 0.82396;

            // Convertir según la moneda elegida
            if (cambiarmoneda == 1)
            {
                Console.Write("\n\t ${0} equivale a {1} Quetzales\n\n", total_dinero, Math.Round(quetzal, 2));
            }
            else if (cambiarmoneda == 2)
            {
                Console.Write("\n\t ${0} equivale a {1} Lempiras\n\n", total_dinero, Math.Round(lempira, 2));
            }
            else if (cambiarmoneda == 3)
            {
                Console.Write("\n\t ${0} equivale a {1} Euros\n\n", total_dinero, Math.Round(euro, 2));
            }
            else
            {
                Console.WriteLine("\n\tCódigo de moneda no válido.");
            }

            // Preguntar si desea salir o continuar
            Console.Write("\n\tSi desea salir presione 1 ó de lo contrario presione otro número: ");
            saliryesno = int.Parse(Console.ReadLine());
            if (saliryesno == 1)
            {
                salir = 1;
            }
        }

        // Pantalla opcional
        Console.WriteLine("\n");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("**************************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("\t* *");
        Console.WriteLine("\t* Este programa fue diseñado por: *");
        Console.WriteLine("\t* *");
        Console.WriteLine("\t* Tu Nombre *");
        Console.WriteLine("\t* *");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("**************************************************");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.ReadKey();
