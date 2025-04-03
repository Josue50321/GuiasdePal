/* Este apartado de codigo simplemente es para diseño de la consola, lo he reutilizado en algunos ejercicios para que lleven mismo formato*/
Console.WindowHeight = 40;  
Console.WindowWidth = 65;    
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Mostrar Números Impares entre dos valores";
/* Decklaramos variables*/ 
int num1, num2;  
do
{
    Console.Clear();  
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\t*    Ingrese dos números y vea los números *");
    Console.WriteLine("\t*    impares entre ellos.                   *");
    Console.WriteLine("\t*********************************************");

    
    Console.Write("Ingrese el primer número (menor): ");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número (mayor): ");
    num2 = int.Parse(Console.ReadLine());

    
    if (num1 >= num2)
    {
        Console.WriteLine("Error: Recuerda que el primer número debe ser menor que el segundo. Intenta nuevamente.");
        Console.WriteLine("Presiona enter para continuar...");
        Console.ReadKey(); 
        continue;  
    }

   
    Console.WriteLine("Los números impares entre {0} y {1} son:", num1, num2);
    for (int i = num1 + 1; i < num2; i++)
    {
        if (i % 2 != 0)  
        {
            Console.WriteLine(" " + i);  
        }
    }

} while (true);  

Console.WriteLine("\n\tPrograma finalizado.");
