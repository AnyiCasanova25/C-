using LSP_3_;

class Program
{
    static void Main(string[] args)
    {
        // Instancia de Dispositivo
        Dispositivo dispositivo = new Dispositivo();
        dispositivo.Encender(); // Salida: "Encender"

        // Instancia de Televisor
        Televisor televisor = new Televisor();
        televisor.Encender(); // Salida: "Encender"

        // Mantener la consola abierta
        Console.ReadLine();
    }
}
