
        /*Tamaño d3e arreglo*/
        int tamaño = 5;
        int[] numeros = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Ingresa el valor para la posición {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        /*Numero a buscar*/
        Console.Write("Ingresa el valor que desea buscar: ");
        int valorBuscar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        int posicion = -1;
        for (int i = 0; i < tamaño; i++)
        {
            if (numeros[i] == valorBuscar)
            {
                encontrado = true;
                posicion = i;
                break;
            }
        }

        /*Resultado*/
        if (encontrado)
        {
            Console.WriteLine($"El valor {valorBuscar} se encuentra en la posición {posicion + 1}.");
        }
        else
        {
            Console.WriteLine("El valor no se encuentra en el arreglo.");
        }
