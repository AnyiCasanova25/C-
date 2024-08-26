using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_5_
{
    //Clase de alto nivel
    public  class AnimalCuidado
    {
        private readonly IAnimal _animal;

        public AnimalCuidado(IAnimal animal)
        {
            _animal = animal;
        }

        public void AlimentarAnimal()
        {
            _animal.Comer();
        }
    }
}
