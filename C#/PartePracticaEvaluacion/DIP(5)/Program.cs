using DIP_5_;

class Program
{
    static void Main(string[] args)
    {
        // Inyección de dependencia - usando la clase Gato
        IAnimal gato = new Gato();
        AnimalCuidado cuidadoConGato = new AnimalCuidado(gato);
        cuidadoConGato.AlimentarAnimal();

        // Ahora cambiamos a otro animal sin modificar el código de alto nivel
        IAnimal perro = new Perro();
        AnimalCuidado cuidadoConPerro = new AnimalCuidado(perro);
        cuidadoConPerro.AlimentarAnimal();

        // Mantener la consola abierta
        //Console.ReadLine();
    }
}