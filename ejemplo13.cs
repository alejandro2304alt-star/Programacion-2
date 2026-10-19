using System;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de constantes
            const double PI = 3.1416;
            const double RADIO = 8.0;
            const double ALTURA = 12.0;
            const double BASE = 10.0;


            double AreaCirculo = PI * Math.Pow(RADIO,2);
            double VolumenCilindro = PI * Math.Pow(RADIO,2) *ALTURA;
            double AreaTriangulo = (BASE * ALTURA)/2;
            double CircunferenciaCirculo = 2 * PI *RADIO;

            Console.WriteLine("Los valores de las constantes son:\n " + "Radio: " + RADIO + "\n" + "Pi: " + PI + "\n" + "Altura: " + ALTURA + "\n" +  "Base: " + BASE + "\n");

            Console.WriteLine("El área del círculo es: " + AreaCirculo);
            Console.WriteLine("El volumen de un cilindro es: " + VolumenCilindro);
            Console.WriteLine("El área del triangulo es: " + AreaTriangulo);
            Console.WriteLine("La circunferencia de un circulo es: " + CircunferenciaCirculo);
        }
    }
}