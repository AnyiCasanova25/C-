using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_5_
{
    internal class Perro : IAnimal
    {
        public void Comer()
        {
            Console.WriteLine("El perro está comiendo.");
        }
    }
}
