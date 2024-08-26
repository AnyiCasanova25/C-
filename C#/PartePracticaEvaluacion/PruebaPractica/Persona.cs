using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractica
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string NamePersona { get; set; }
        public int Telefono { get; set; }
        public int AgePersona { get; set; }
        public string AddressPersona { get; set; }

        public Persona( string namePersona, int telefono ,int agePersona, string addressPersona)
        {
            IdPersona = 123;
            NamePersona = namePersona;
            Telefono = telefono;
            AgePersona = agePersona;
            AddressPersona = addressPersona;
        }

        public virtual void InfoPersona()
        {
            Console.WriteLine($"ID: {IdPersona}");
            Console.WriteLine($"Nombre: {NamePersona}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine($"Edad: {AgePersona}");
            Console.WriteLine($"Dirección: {AddressPersona}");
        }
    }
}
