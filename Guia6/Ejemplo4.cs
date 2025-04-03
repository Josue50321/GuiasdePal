int dato, k, suma;

// Leer el número
Console.Write("Ingresa un número: ");
dato = int.Parse(Console.ReadLine());

k = 1;
suma = 0;

// Mientras k <= (dato DIV 2)
while (k <= dato / 2)
{
    // Si (dato MOD k) == 0
    if (dato % k == 0)
    {
        suma = suma + k;
    }

    k = k + 1;
}

// Si la suma de los divisores es igual al número, es perfecto
if (suma == dato)
{
    Console.WriteLine("Es número perfecto...");
}
else
{
    Console.WriteLine("No es perfecto...");
}