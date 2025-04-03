
        Console.Write("Ingrese la cantidad de empleados: ");
        int numEmpleados = int.Parse(Console.ReadLine());

        int rango100a300 = 0;
        int rangoMas350 = 0;

        for (int i = 0; i < numEmpleados; i++)
        {
            Console.Write($"Ingrese el sueldo del empleado {i + 1}: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            if (sueldo >= 100 && sueldo <= 300)
            {
                rango100a300++;
            }
            else if (sueldo > 350)
            {
                rangoMas350++;
            }
        }

        Console.WriteLine($"Empleados con sueldo entre $100 y $300: {rango100a300}");
        Console.WriteLine($"Empleados con sueldo mayor a $350: {rangoMas350}");


