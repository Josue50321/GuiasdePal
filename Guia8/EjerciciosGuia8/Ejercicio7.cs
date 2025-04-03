
        /* Crear un arreglo de 7 elementos para los números */
        int[] valores = new int[7];
        int temp;

        Console.WriteLine("Por favor, Ingresa 7 números enteros:");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Número {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());
        }

        /* Orden en orden ascendente*/
        for (int i = 0; i < valores.Length - 1; i++)
        {
            for (int j = 0; j < valores.Length - 1 - i; j++)
            {
                if (valores[j] > valores[j + 1])
                {
                    /*Intercambia los valores*/
                    temp = valores[j];
                    valores[j] = valores[j + 1];
                    valores[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nOrden ascendente:");
        foreach (var num in valores)
        {
            Console.Write(num + " ");
        }
        for (int i = 0; i < valores.Length - 1; i++)
        {
            for (int j = 0; j < valores.Length - 1 - i; j++)
            {
                if (valores[j] < valores[j + 1])
                {
                    temp = valores[j];
                    valores[j] = valores[j + 1];
                    valores[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nOrden descendente:");
        foreach (var num in valores)
        {
            Console.Write(num + " ");
        }
  
        /* Este ejercicio en especial se me complico por lo que tuve que usar IA para guiarme y colocar algunas funcionalidades, ya que no me estaba funcionando*/