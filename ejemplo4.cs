using System;

namespace interpolacion_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            string edad = Console.ReadLine();
            int edadEntera = int.Parse(edad);

            int edadFutura = edadEntera + 14;
            Console.WriteLine($"\nSaludos, {nombre}.\nTienes {edad} años.\nEn 14 años tendrás {edadFutura} años.");
        }
    }
}