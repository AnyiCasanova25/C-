using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2_
{
    //MAL
    //MODIFICAR LA CLASE BASE PARA AGREGAR UN NUEVO TIPO DE CARRO

    //public class Carro
    //{
    //    public void Arrancar()
    //    {
    //        Console.WriteLine("Arranca");
    //    }
    //}
    //public class CarroElectrico : Carro
    //{
    //    public void Arrancar()
    //    {
    //        Console.WriteLine("Arranca");
    //    }
    //}

    //BIEN
    //AGREGAR UN NUEVO TIPO DE CARRO SIN MODIFICAR LA CLASE BASE
    public class Carro
    {
        public virtual void Arrancar()
        {
            Console.WriteLine("Arranca");
        }
    }

    public class CarroElectrico : Carro 
    {
        public override void Arrancar()
        {
            base.Arrancar();
        }
    }
}
