
Console.WriteLine("Ingrese 5 numeros para sumarlos: ");
int Suma = 0;
for (int i = 1; i <= 5 ; i++)
{
    Console.WriteLine($"Numero {i}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Suma += num;
}
Console.WriteLine($"\n La suma total es: {Suma}");