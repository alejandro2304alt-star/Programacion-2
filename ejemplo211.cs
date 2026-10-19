using System;
class Program
{
    public enum DiaSemana
    {
        Lunes = 1,
        Martes = 2,
        Miercoles = 3,
        Jueves = 4,
        Viernes = 5,
        Sabado = 6,
        Domingo = 7
    }
    public enum Meses
    {
        Enero = 1,
        Febrero = 2,
        Marzo = 3,
        Abril = 4,
        Mayo = 5,
        Junio = 6,
        Julio = 7,
        Agosto = 8,
        Septiembre = 9,
        Octubre = 10,
        Noviembre = 11,
        Diciembre = 12
    }
    static void Main(string[] args)
    {
        Console.Write("Ingrese el número correspondiente al día de la semana (1-7): ");
        int numDiaSemana = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el dia del mes (1-31): ");
        int numerodedia = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el número correspondiente al mes (1-12): ");
        int numMes = int.Parse(Console.ReadLine());

        if (numDiaSemana >= 1 && numDiaSemana <= 7 && numerodedia >= 1 && numerodedia <= 31 && numMes >= 1 && numMes <= 12)
        {
            string nombreDia = ((DiaSemana)numDiaSemana).ToString();
            
            string nombreMes = "";
            switch (numMes)
            {
                case (int)Meses.Enero:
                    nombreMes = "enero";
                    break;
                case (int)Meses.Febrero:
                    nombreMes = "febrero";
                    break;
                case (int)Meses.Marzo:
                    nombreMes = "marzo";
                    break;
                case (int)Meses.Abril:
                    nombreMes = "abril";
                    break;
                case (int)Meses.Mayo:
                    nombreMes = "mayo";
                    break;
                case (int)Meses.Junio:
                    nombreMes = "junio";
                    break;
                case (int)Meses.Julio:
                    nombreMes = "julio";
                    break;
                case (int)Meses.Agosto:
                    nombreMes = "agosto";
                    break;
                case (int)Meses.Septiembre:
                    nombreMes = "septiembre";
                    break;
                case (int)Meses.Octubre:
                    nombreMes = "octubre";
                    break;
                case (int)Meses.Noviembre:
                    nombreMes = "noviembre";
                    break;
                case (int)Meses.Diciembre:
                    nombreMes = "diciembre";
                    break;
                default:
                    nombreMes = "desconocido";
                    break;
            }
            Console.WriteLine("\nFecha resultante:");
            Console.WriteLine($"Hoy es {nombreDia} {numerodedia} de {nombreMes} de 2026");
        }
        else
        {
            Console.WriteLine("\nError: valores ingresados fuera de rango.");
        }
    }
}