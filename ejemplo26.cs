/* Objetivo de aprendizaje
Integrar estructuras repetitivas y de selección para crear aplicaciones interactivas de consola.

Instrucciones
Desarrollar una aplicación en C# que muestre el siguiente menú:
===== MENÚ PRINCIPAL =====

1. Mostrar nombre
2. Mostrar edad
3. Limpiar pantalla
4. Salir
Utilizar un ciclo do while para mantener el menú activo.
Utilizar switch para procesar las opciones.
Mostrar un nombre predefinido en la opción 1.
Mostrar una edad predefinida en la opción 2.
Utilizar Console.Clear() en la opción 3.
Finalizar únicamente cuando el usuario seleccione la opción 4.*/

string nombre = "Mario Simarro";
int edad = 55;
int opcion;

do
{
    Console.WriteLine("===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Mostrar nombre");
    Console.WriteLine("2. Mostrar edad");
    Console.WriteLine("3. Limpiar pantalla");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"El nombre es {nombre}.\n");
            break;
        case 2:
            Console.WriteLine($"La edad es {edad} años.\n");
            break;
        case 3:
            Console.Clear();
            break;
        case 4:
            Console.WriteLine("Cerrando el programa.");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            break;
    }
} while (opcion != 4);
