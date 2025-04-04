using System;
using System.Collections.Generic;

class Programa
{
    static List<Persona> personas = new List<Persona>(); 

    static void Main()
    {
        string opcion;

        /*Diseño de la consola*/
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear(); 

        do
        {
          
            Console.WriteLine("------------------- Menú -------------------");

            Console.WriteLine("1. Agregar personas");
            Console.WriteLine("2. Ver quiénes cumplen años hoy");
            Console.WriteLine("3. Ver quiénes cumplen años en una fecha específica");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");
            Console.WriteLine("------------------- ---- -------------------");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarPersonas();
                    break;

                case "2":
                    VerificarCumpleanosHoy();
                    break;

                case "3":
                    VerificarCumpleanosFechaEspecifica();
                    break;

                case "4":
                    Console.Clear();
                    break;

                default:
                    /*Si no se selecciona nada de las opciones posibles*/
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ResetColor();
                    break;
            }
        } while (opcion != "4");
    }

    static void AgregarPersonas()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("¿Cuántas personas deseas agregar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Persona #{i + 1}");
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la fecha de nacimiento (formato: dd/mm/yyyy): ");
            DateTime fechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            personas.Add(new Persona(nombre, fechaNacimiento));
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{n} personas han sido agregadas.");
        Console.ResetColor();
    }

    static void VerificarCumpleanosHoy()
    {
        DateTime hoy = DateTime.Today;
        Console.WriteLine("Las personas que cumplen años hoy son:");

        bool encontrados = false;

        foreach (var persona in personas)
        {
            if (persona.FechaNacimiento.Day == hoy.Day && persona.FechaNacimiento.Month == hoy.Month)
            {
                int edad = hoy.Year - persona.FechaNacimiento.Year;
                if (persona.FechaNacimiento > hoy.AddYears(-edad)) edad--;
                Console.WriteLine($"{persona.Nombre} está cumpliendo {edad} años.");
                encontrados = true;
            }
        }

        if (!encontrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nadie cumple años hoy.");
            Console.ResetColor();
        }
    }

    static void VerificarCumpleanosFechaEspecifica()
    {
        Console.Write("Ingrese el día (formato: dd): ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes (formato: mm): ");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine($"Las personas que cumplen años el {dia}/{mes} son:");

        bool encontrados = false;

        foreach (var persona in personas)
        {
            if (persona.FechaNacimiento.Day == dia && persona.FechaNacimiento.Month == mes)
            {
                Console.WriteLine($"{persona.Nombre}");
                encontrados = true;
            }
        }

        if (!encontrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No hay personas que cumplan años en esa fecha.");
            Console.ResetColor();
        }
    }
}

class Persona
{
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Persona(string nombre, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
    }
}
