Console.WindowHeight = 30; // alto de la ventana
Console.WindowWidth = 63; // ancho de la ventana
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
// Titulo
Console.Title = ("Conjunto de 9 numeros con while");
Console.Write("\n\tGuia#6 Ejemplo2");
// Declaración de variables
int num; // los 2 numeros
int a = 1, x = 0, y = 0, z = 0;
// Entrada y Proceso de datos
Console.Write("\n\tEscribiremos 9 numeros enteros");
Console.WriteLine("\n");

while (a <= 9)
{
    Console.Write("\tEl numero [" + a + "] es: ");

    // Usamos TryParse para evitar errores con entradas no válidas
    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num < 15)
        {
            x = x + 1;
        }
        if (num > 85)
        {
            y = y + 1;
        }
        if ((num >= 50) && (num <= 150))
        {
            z = z + 1;
        }
        a = a + 1;  // Incrementamos el contador solo si la entrada es válida
    }
    else
    {
        // Si la entrada no es válida, mostramos un mensaje y no incrementamos el contador
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t⚠️ Entrada no válida. Por favor ingrese un número.");
        Console.ForegroundColor = ConsoleColor.Black;
    }
}

Console.WriteLine("\n");
Console.WriteLine("\t*********************************************");
Console.WriteLine("\t Los numeros menores a 15 son : " + x);
Console.WriteLine("\t Los numeros mayores a 85 son : " + y);
Console.WriteLine("\t Los numeros entre 50 y 150 son : " + z);
Console.WriteLine("\t*********************************************");
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
