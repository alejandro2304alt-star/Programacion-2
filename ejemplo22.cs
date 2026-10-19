Console.WriteLine("Ingrese un numero positivo: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    int contador = 1;
    while (contador <= numero)
    {
        Console.WriteLine(contador);
        contador = contador + 1;}
}
else
{
    Console.WriteLine("Debe ingresar un numero entero positivo mayor que 0");
}
