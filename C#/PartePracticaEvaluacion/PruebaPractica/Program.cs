using PruebaPractica;
using System.Drawing;

public class Program
{
    static async Task Main(string[] args)
    {
       
        Console.WriteLine("Por favor, ingrese el nombre de la persona:");
        string namePersona = Console.ReadLine();

        Console.WriteLine("Por favor, ingrese el telefono de la persona:");
        int telefono = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la edad de la persona:");
        int agePersona = Convert.ToInt32(Console.ReadLine());
        //EL TOINT sirve para convertir un string a enterooooooo

        Console.WriteLine("Por favor, ingrese la dirección de la persona:");
        string addressPersona = Console.ReadLine();

        // Solicitar datos para Empleado
        Console.WriteLine("Por favor, ingrese el número de días trabajados:");
        int diasTrabajados = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Trayendo datos, por favor espere...");
        Empleado empleado = await CrearEmpleadoAsync(namePersona,telefono, agePersona, addressPersona, diasTrabajados);

        empleado.InfoPersona();

        Console.ReadKey();
    }

    static async Task<Empleado> CrearEmpleadoAsync(string namePersona,int telefono, int agePersona, string addressPersona, int diasTrabajados)
    {
        await Task.Delay(5000); 
        return new Empleado(namePersona,telefono, agePersona, addressPersona, diasTrabajados);
    }
}