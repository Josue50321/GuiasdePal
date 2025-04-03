Console.WindowHeight = 30; // alto de la ventana
Console.WindowWidth = 70; //ancho de la ventana
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Sumatoria y Promedio de goles de un futbolista";
Console.Write("\n\tGuia#6 Ejemplo1");
Console.WriteLine("\n");

// Declaracion de variables
int contador = 1;
Double suma = 0;
int N;
Double prom;
String juga;

// Entrada y Procesos de datos
Console.Write("\tDigita el nombre del jugador de futbol : ");
juga = Console.ReadLine();
Console.WriteLine("\n");

while (contador <= 5)
{
    Console.Write("\tIngrese una cantidad de goles [" + contador + "]: ");
    N = int.Parse(Console.ReadLine());
    suma = suma + N;
    contador = contador + 1;
}

Console.WriteLine("\n");
Console.Write("\tLa sumatoria de goles es de: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(suma);
Console.ForegroundColor = ConsoleColor.Black;

prom = suma / 5;
Console.WriteLine("\n\n");
Console.Write("\tEl promedio de goles de " + juga + " es de: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(Math.Round(prom, 2));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\n\n");

//Pantalla opcional
Console.Write("\t");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("*********************************************");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("\t* *");
Console.WriteLine("\t* Este programa fue diseñado por: *");
Console.WriteLine("\t* *");
Console.WriteLine("\t Bryan Otoniel Loarca Montenegro");
Console.WriteLine("\t* *");
Console.Write("\t");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("*********************************************");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.White;
Console.Write("\t");
Console.WriteLine("--> Fin del Programa");
Console.Write("\t");
Console.ReadKey();