Console.WindowHeight = 40;  
Console.WindowWidth = 65;   
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();


int numero;  
do
{
    Console.Clear();  
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\t*   Ingrese un número entre 1 y 15 para    *");
    Console.WriteLine("\t*   mostrar esa cantidad de asteriscos.     *");
    Console.WriteLine("\t*********************************************");
    Console.Write("\n\tIngrese un número entre 1 y 15: ");
    numero = int.Parse(Console.ReadLine());  
    
    if (numero < 1 || numero > 15)
    {
        Console.WriteLine("Número no valido. Por favor ingresa un número que se encuentre entre 1 y 15.");
    }
    else
    {
        
        Console.WriteLine("Asteriscos: ");
        for (int i = 0; i < numero; i++)
        {
            Console.Write("*");  
        }
        Console.WriteLine();  
    }

    
    Console.Write("Presione ENTER para continuar o cualquier otra tecla para salir...");
    char continuar = Console.ReadKey().KeyChar;
    if (continuar != '\r')  
    {
        break;  
    }
} while (true);  

Console.WriteLine("\n\tFin del programa.");
