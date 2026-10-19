string Contrasena = "alejandrorosario";
string ingreso;
do
{
    Console.Write("Pon la contraseña: ");
    ingreso = Console.ReadLine();
    if (ingreso != Contrasena)
    {
        Console.WriteLine("Contraseña incorrecta. Intente de nuevo.\n");
    }
} while (ingreso != Contrasena);
Console.WriteLine("\nContraseña correcta.");