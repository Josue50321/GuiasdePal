
/*Codigo ¿para la consola reutilizado*/
Console.WindowHeight = 40;  
Console.WindowWidth = 65;  
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Conversión de Coordenadas Polares a Rectangulares";

double r, theta, x, y;  

do
{
    Console.Clear();  
    Console.WriteLine("\t*********************************************");
    Console.WriteLine("\t*     Conversión de Coordenadas Polares     *");
    Console.WriteLine("\t*     a Coordenadas Rectangulares           *");
    Console.WriteLine("\t*********************************************");

    
    Console.Write("Coloca el valor de la distancia radial: ");
    r = double.Parse(Console.ReadLine());

    
    if (r < 0)
    {
        Console.WriteLine("La distancia radial no puede ser negativa.");
        Console.WriteLine("Enter si quieres seguir");
        Console.ReadKey();
        continue; 
    }


    Console.Write("Coloca el valor del ángulo (θ) en grados: ");
    theta = double.Parse(Console.ReadLine());

    /*Formula que da la guia 1*/
    double thetaRad = Math.PI * theta / 180;

    /*Polares a rectangulares*/
    ConvertirPolaresARectangulares(r, thetaRad, out x, out y);

    Console.WriteLine($"tLas coordenadas rectangulares son:");
    Console.WriteLine($"X = {x}");
    Console.WriteLine($"Y = {y}");

    /*Reutilizo formula de las pasadas*/
    Console.Write("\n\t¿Desea realizar otra conversión? (S/N): ");
    char respuesta = Console.ReadKey().KeyChar;
    if (respuesta != 'S' && respuesta != 's')
    {
        break;  
    }

} while (true);  

Console.WriteLine("\n\tPrograma finalizado.");

/* Función para convertir coordenadas polares a coordenadas rectangulares*/
static void ConvertirPolaresARectangulares(double r, double theta, out double x, out double y)
{
    x = r * Math.Cos(theta); 
    y = r * Math.Sin(theta); 
}
/* Este ejercicio se me complico por lo tanto algunas funcionalidades le pedi a IA que me diera como funcionaria*/