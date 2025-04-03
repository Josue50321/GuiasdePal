
Console.WindowHeight = 40;  
Console.WindowWidth = 65;   
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Menú Interactivo de Operaciones";

/*Declaramos variables*/
int opcion;  

do
{ /*Codigo reutilizado*/
    Console.Clear();  
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\t*               MENÚ INTERACTIVO           *");
    Console.WriteLine("\t*           1) Dividir 2 números enteros    *");
    Console.WriteLine("\t*           2) Obtener el cubo de un número *");
    Console.WriteLine("\t*           3) Cálculo de IMC (Índice de   *");
    Console.WriteLine("\t*              Masa Corporal)               *");
    Console.WriteLine("\t*           4) Salir                        *");
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\n\tSeleccione una opción (1-4): ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            DividirNumeros();  
            break;
        case 2:
            ObtenerCubo();  
            break;
        case 3:
            CalcularIMC();
            break;
        case 4:
            Console.WriteLine("Ha decidido salir del programa.");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }

    if (opcion != 4)
    {
        Console.Write("Para continuar presiona cualquier tecla o 'ESC' para salir: ");
        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Escape) break;
    }

} while (opcion != 4);  

Console.WriteLine("\n\tPrograma finalizado.");

static void DividirNumeros()
{
    try
    {
        int num1, num2;
        Console.Write("\n\tIngrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("\n\tIngrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("\n\tError: No se puede dividir entre cero.");
        }
        else
        {
            double resultado = (double)num1 / num2;
            Console.WriteLine($"\n\tEl resultado de {num1} dividido entre {num2} es: {resultado}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n\tError: " + ex.Message);
    }
}

static void ObtenerCubo()
{
    try
    {
        int num;
        Console.Write("\n\tIngrese un número entero: ");
        num = int.Parse(Console.ReadLine());
        int cubo = num * num * num;
        Console.WriteLine($"\n\tEl cubo de {num} es: {cubo}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n\tError: " + ex.Message);
    }
}

static void CalcularIMC()
{
    try
    {
        double peso, altura, imc;
        Console.Write("\n\tIngrese su peso en kilogramos (Kg): ");
        peso = double.Parse(Console.ReadLine());
        Console.Write("\n\tIngrese su altura en metros (m): ");
        altura = double.Parse(Console.ReadLine());

        if (altura <= 0)
        {
            Console.WriteLine("\n\tError: La altura no puede ser cero o negativa.");
        }
        else
        {
            imc = peso / (altura * altura);
            Console.WriteLine($"\n\tSu Índice de Masa Corporal (IMC) es: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("\tCategoría: Bajo peso.");
            else if (imc >= 18.5 && imc < 24.9)
                Console.WriteLine("\tCategoría: Normal.");
            else if (imc >= 25 && imc < 29.9)
                Console.WriteLine("\tCategoría: Sobrepeso.");
            else
                Console.WriteLine("\tCategoría: Obesidad.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("\n\tError: " + ex.Message);
    }
}
