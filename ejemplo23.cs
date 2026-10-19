Console.Write("Ingrese un número para ver su tabla: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabla de multiplicar del {numero}:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}