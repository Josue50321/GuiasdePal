
        int numero, contador, k;

        // Leer el número
        Console.Write("Ingresa un número: ");
        numero = int.Parse(Console.ReadLine());

        contador = 0;
        k = 1;

        // Mientras k <= numero
        while (k <= numero)
        {
            // Si (numero MOD k) == 0
            if (numero % k == 0)
            {
                contador = contador + 1;
            }

            k = k + 1;
        }

// Si el número tiene exactamente 2 divisores, es primo
if (contador == 2)
{
    Console.WriteLine("Es un número primo");
}
else
{
    Console.WriteLine("El número no es primo");
}