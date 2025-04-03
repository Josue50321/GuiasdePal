
        Console.Write("Ingrese el número de piezas a procesar: ");
        int totalPiezas = int.Parse(Console.ReadLine());

        int piezasValidas = CalcularPiezasValidas(totalPiezas);

        Console.WriteLine($"La cantidad de piezas válidas es: {piezasValidas}");
 

    static int CalcularPiezasValidas(int totalPiezas)
    {
        int piezasValidas = 0;

        for (int indice = 0; indice < totalPiezas; indice++)
        {
            double longitudPieza = SolicitarLongitudPieza(indice);

       
            if (longitudPieza >= 1.20 && longitudPieza <= 1.40)
            {
                piezasValidas++;  
            }
        }

        return piezasValidas;  
    }

    static double SolicitarLongitudPieza(int indice)
    {
        Console.Write($"Ingrese la longitud de la pieza número {indice + 1}: ");
        double longitud = double.Parse(Console.ReadLine());
        return longitud;
    }