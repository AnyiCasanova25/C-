using ISP_4_;

public class program
{
    static void Main(string[] arg)
    {
       Printer printer = new Printer();
        printer.Imprimir();

        Scanner scanner = new Scanner();
        scanner.Escanear();

        Fax fax = new Fax();
        fax.EnviarFax();
    }
}