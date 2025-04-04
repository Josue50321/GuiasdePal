
        /* Darle diseño al fondo de la consola y al texto*/
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        /*Declaramos variables como seran palabras lo hacemos tipo string*/
        string[] palabras = { "Montaña", "Rompecabezas", "Zanahoria", "Antilope", "Sopa" };

        while (true)
        {
            /* Empezamos con la creación del menu para el usuario*/
            Console.Clear();
            MostrarEncabezado();
            Console.WriteLine("=============== MENÚ PRINCIPAL ===============");
            Console.WriteLine("1. Jugar");
            Console.WriteLine("2. Salir");
            Console.Write("Selecciona una opción: ");
            Console.WriteLine("\n=============================================");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Juego(palabras);
                    break;
                case "2":
                    return; 
                default:
                    Console.WriteLine("Por favor selecciona 1 o 2.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void Juego(string[] palabras)
    {
        Random rand = new Random();
        string palabra = palabras[rand.Next(palabras.Length)];
        string[] pistas = ObtenerPistas(palabra);
        string palabraOculta = new string('*', palabra.Length);
        int intentos = 6, pistaIndex = 0;
        string letrasIntentadas = "";
        bool adivinada = false, primeraPistaMostrada = false;

        Console.Clear();
        MostrarEncabezado();
        Console.WriteLine("Comencemos con el juego de ahporcado");

        while (intentos > 0 && !adivinada)
        {
            /*Se oculta las palabras y se muestran los intentos que aun quedan*/
            Console.Clear();
            MostrarEncabezado();
            Console.WriteLine($"Palabra: {palabraOculta}");
            Console.WriteLine($"Intentos restantes: {intentos}");
            if (primeraPistaMostrada) Console.WriteLine($"Pista: {pistas[pistaIndex]}");
            Console.Write("Introduce una letra: ");

            string entrada = Console.ReadLine();
            if (entrada.Length != 1 || !char.IsLetter(entrada[0]))
            {
                Console.WriteLine("Por favor, introduce una sola letra.");
                continue;
            }

            char letra = char.ToLower(entrada[0]);

            if (letrasIntentadas.Contains(letra))
            {
                Console.WriteLine("Ya has intentado esa letra.");
                continue;
            }

            letrasIntentadas += letra;

            /*Se checa si la letra que se pone esta en la palabra oculta*/
            if (palabra.ToLower().Contains(letra))
            {
                Console.WriteLine($"¡Correcto! La letra '{letra}' está en la palabra.");
                palabraOculta = ActualizarPalabraOculta(palabra, palabraOculta, letra);
            }
            else
            {
                intentos--;
                Console.WriteLine($"Incorrecto. Te quedan {intentos} intentos.");

                if (!primeraPistaMostrada && intentos < 6)
                {
                    primeraPistaMostrada = true;
                    Console.WriteLine("Pista: " + pistas[pistaIndex]);
                }
                else if (intentos < 6 && pistaIndex < pistas.Length - 1)
                {
                    pistaIndex++;
                }
            }

            if (!palabraOculta.Contains('*'))
            {
                adivinada = true;
                Console.Clear();
                MostrarEncabezado();
                Console.WriteLine($"¡Felicidades! Has adivinado la palabra: {palabra}");
                Console.ReadKey();
                return;
            }
        }

        /*Si ya no tiene mas intentos*/
        if (intentos == 0)
        {
            Console.Clear();
            MostrarEncabezado();
            Console.WriteLine($"¡Lo siento! Has perdido. La palabra era: {palabra}");
            Console.ReadKey();
        }
    }

    static string[] ObtenerPistas(string palabra)
    {
        switch (palabra)
        {
            case "Montaña":
                return new string[]
                {
                    "Es un terreno elevado, generalmente de gran altura.",
                    "Se encuentra comúnmente en zonas rurales o naturales.",
                    "Es más alta que una colina.",
                    "Es un lugar donde puedes hacer senderismo.",
                    "Hay -montañas- famosas como el Everest o los Andes. ¿Conoces alguna montaña?"
                };
            case "Rompecabezas":
                return new string[]
                {
                    "Es un juego que consiste en piezas que se deben encajar.",
                    "Las piezas tienen diferentes formas y tamaños.",
                    "Este juego desarrolla habilidades cognitivas y paciencia.",
                    "Cuando está completo, muestra una imagen o dibujo.",
                    "Tal vez te rompas la cabeza intentando armarlo"
                };
            case "Zanahoria":
                return new string[]
                {
                    "Es una raíz comestible, generalmente de color naranja.",
                    "Se encuentra en el suelo y crece en climas frescos.",
                    "Es buena para la vista por su alto contenido de vitamina A.",
                    "Es un ingrediente común en ensaladas y sopas.",
                    "Los conejos la comen. ¿Alguna idea?"
                };
            case "Antilope":
                return new string[]
                {
                    "Es un animal herbívoro que vive en sabanas y praderas.",
                    "Tiene cuernos y es ágil para escapar de los depredadores.",
                    "Es común en África y Asia.",
                    "Suelen vivir en grupos y se alimentan de pasto.",
                    "El -antílope- más conocido es el impala."
                };
            case "Sopa":
                return new string[]
                {
                    "Es un líquido caliente generalmente servido como comida.",
                    "Es común en las comidas de invierno.",
                    "Se puede hacer a base de verduras, carne o fideos.",
                    "Es un plato que suele acompañarse de pan o arroz.",
                    "¿No quieres sopa?"
                };
            default:
                return new string[] { "Pista no disponible." };
        }
    }

    static string ActualizarPalabraOculta(string palabra, string palabraOculta, char letra)
    {
        char[] palabraArray = palabraOculta.ToCharArray();
        for (int i = 0; i < palabra.Length; i++)
        {
            if (char.ToLower(palabra[i]) == letra)
                palabraArray[i] = palabra[i];
        }
        return new string(palabraArray);
    }

    static void MostrarEncabezado()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("***********************************************");
        Console.WriteLine("*                                             *");
        Console.WriteLine("*         Juego de Ahorcado - Alfaro          *");
        Console.WriteLine("*                                             *");
        Console.WriteLine("***********************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
  