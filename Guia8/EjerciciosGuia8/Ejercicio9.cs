
int contador = 0;

/* Use bucle do-whil¨*/
Console.WriteLine("Ingresa los precios de los 6 productos:");
do
{
    Console.Write($"Precio del producto {contador + 1}: ");
    Mercadito[contador] = double.Parse(Console.ReadLine());
    contador++;
} while (contador < Mercadito.Length);

int preciosMayores25 = 0;
for (int i = 0; i < Mercadito.Length; i++)
{
    if (Mercadito[i] > 25)
    {
        preciosMayores25++;
    }
}
Console.WriteLine($"Cantidad de precios mayores a $25: {preciosMayores25}")