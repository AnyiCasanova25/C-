using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_5_
{
    //Clase de bajo nivel
    public class Gato : IAnimal
    {
        public void Comer()
        {
            Console.WriteLine("El gato está comiendo.");
        }
    }
}
