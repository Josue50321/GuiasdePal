/*Programa realizado por mi XD */

Console.WindowHeight = 40;  // alto de la ventana
Console.WindowWidth = 65;   // ancho de la ventana 
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Menú de Operaciones Matemáticas";

int opcion;
double x, y, resultado;
bool continuar = true;

do
{
    Console.Clear();  
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\t*    Menú de Operaciones Matemáticas       *");
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\n\t    [1] Seno de x");
    Console.WriteLine("\t    [2] Coseno de x");
    Console.WriteLine("\t    [3] Tangente de x");
    Console.WriteLine("\t    [4] Raíz cuadrada de x");
    Console.WriteLine("\t    [5] Potencia de Y^x");
    Console.WriteLine("\t    [6] Verificar si un número es par o impar");
    Console.WriteLine("\t    [7] Salir del programa");
    Console.WriteLine("\t*********************************************");
    Console.Write("\n\tSeleccione una opción (1..7): ");

    opcion = int.Parse(Console.ReadLine());  

    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.Write("\tIngrese el valor de x para el seno: ");
            x = double.Parse(Console.ReadLine());
            resultado = Math.Sin(x * Math.PI / 180); 
            Console.WriteLine("\tEl seno de {0} es: {1}", x, resultado);
            break;

        case 2:
            Console.Clear();
            Console.Write("\tIngrese el valor de x para el coseno: ");
            x = double.Parse(Console.ReadLine());
            resultado = Math.Cos(x * Math.PI / 180); 
            Console.WriteLine("\tEl coseno de {0} es: {1}", x, resultado);
            break;

        case 3:
            Console.Clear();
            Console.Write("\tIngrese el valor de x para la tangente: ");
            x = double.Parse(Console.ReadLine());
            resultado = Math.Tan(x * Math.PI / 180); 
            Console.WriteLine("\tLa tangente de {0} es: {1}", x, resultado);
            break;

        case 4:
            Console.Clear();
            Console.Write("\tIngrese el valor de x para la raíz cuadrada: ");
            x = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("\tNo se puede calcular la raíz cuadrada de un número negativo.");
            }
            else
            {
                resultado = Math.Sqrt(x); 
                Console.WriteLine("\tLa raíz cuadrada de {0} es: {1}", x, resultado);
            }
            break;

        case 5:
            Console.Clear();
            Console.Write("\tIngrese el valor de Y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("\tIngrese el valor de x para la potencia: ");
            x = double.Parse(Console.ReadLine());
            resultado = Math.Pow(y, x); 
            Console.WriteLine("\tEl resultado de {0}^{1} es: {2}", y, x, resultado);
            break;

        case 6:
            Console.Clear();
            Console.Write("\tIngrese un número para verificar si es par o impar: ");
            x = double.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("\tEl número {0} es par.", x);
            }
            else
            {
                Console.WriteLine("\tEl número {0} es impar.", x);
            }
            break;

        case 7:
            Console.Clear();
            Console.WriteLine("\tSaliendo del programa...");
            continuar = false; 
            break;

        default:
            Console.Clear();
            Console.WriteLine("\tOpción no válida. Por favor seleccione una opción entre 1 y 7.");
            break;
    }

    if (continuar)
    {
        Console.Write("\n\tPresione ENTER para continuar...");
        Console.ReadKey();  
    }

} while (continuar);

Console.WriteLine("\n\tFin del programa.");

