// Programa realizado por  
// Día: Marzo 13, 2023 

Console.WindowHeight = 40;  // alto de la ventana 
Console.WindowWidth = 65;   // ancho de la ventana 
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Control de sueldos de 6 empleados usando un vector";

Console.Write("\nGuia#8 Ejemplo1");
Console.WriteLine("\n");

// Declaración del vector llamado Sueldos de tamaño 6 
Double[] Sueldos = new Double[6];
int i;

Console.WriteLine("\t*********************************************");
Console.WriteLine("\t*         EMPRESA LOS TULIPANES             *");
Console.WriteLine("\t*          Control de salarios              *");
Console.WriteLine("\t*********************************************");
Console.WriteLine("\n");

// Ingreso de sueldos
for (i = 0; i < 6; i++)
{
    Console.Write("\tIngrese el sueldo del empleado [" + i + "]:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" $");
    Sueldos[i] = Double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Black;
}

Console.WriteLine("\n\tLos sueldos ingresados son:");
Console.WriteLine("\n");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("\t");

// Mostrar sueldos ingresados
for (i = 0; i < 6; i++)
{
    Console.Write("$" + Sueldos[i] + "  ");
}

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\n\n");
Console.WriteLine("\n\tPresione ENTER para terminar");
Console.ReadKey();
