/*Codigo de consola reutilizado*/
Console.WindowHeight = 40;  
Console.WindowWidth = 65;   
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Cálculo de Edad";

int añoNacimiento;  /* Variable de tipo entero ya que es para el año de nacimiento*/
int edad;           /* Variable tipo entero para la edad */


do
{
    Console.Clear();  
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\t*    Cálculo de Edad                         *");
    Console.WriteLine("\t*    Ingrese su año de nacimiento.           *");
    Console.WriteLine("\t*********************************************");

   
    Console.Write("Ingrese su año de nacimiento: ");

    añoNacimiento = int.Parse(Console.ReadLine());

    if (añoNacimiento > DateTime.Now.Year)
    {
        Console.WriteLine("Coloca un año menor o igul al 2025");
        Console.WriteLine("Enter si gustas seguir...");
        Console.ReadKey();  
        continue; 
    }

   /*Empezamos con el uso de procedimientos*/
    CalcularEdad(añoNacimiento, out edad);

    Console.WriteLine($"Tu edad es: {edad} años.");

    /*Codigo reusado*/
    Console.Write("Deseas realizar otro cálculo? (S/N): ");
    char respuesta = Console.ReadKey().KeyChar;  
    if (respuesta != 'S' && respuesta != 's')  
    {
        break;  
    }

} while (true);  

Console.WriteLine("\n\tPrograma finalizado.");


static void CalcularEdad(int añoNacimiento, out int edad)
{
    int añoActual = DateTime.Now.Year; 
    edad = añoActual - añoNacimiento;   
}
