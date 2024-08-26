public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando descarga");
        Console.WriteLine("Esto podria tardar 5 segundos");

        var resultado = await BaseFalsa();
        Console.WriteLine(resultado);
    }

    static async Task<string> BaseFalsa()
    {
        await Task.Delay(5000);
        return "Descarga finalizada con exito!!!";
    }
}
