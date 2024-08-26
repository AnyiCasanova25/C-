using SRP_1_;

class Program
{
    static void Main(string[] args)
    {
       
        Humedad humedad = new Humedad();
        Temperatura temperatura = new Temperatura();

        humedad.ControlarHumedad();
        temperatura.ControlarTemperatura();
    }
}