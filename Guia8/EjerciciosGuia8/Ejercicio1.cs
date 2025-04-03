var Notas = new double[9];
int contador = 0;

Console.WriteLine("Ingrese las 9 notas:");

for (int i = 0; i < 9; i++)
{
    Console.Write("Nota " + (i + 1) + ": ");
    Notas[i] = double.Parse(Console.ReadLine());

    if (Notas[i] == 8.5)
    {
        contador++;
    }
}

Console.WriteLine("Notas iguales a 8.5: " + contador);