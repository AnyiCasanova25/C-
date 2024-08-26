using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_3_
{
    //UNA CLASE QUE NO PUEDE SER REEMPLAZADA POR SUS SUBCLASES
    public class Dispositivo
    {
        public void Encender()
        {
            Console.WriteLine("Encender");
        }
    }
    public class Televisor
    {
        public void Encender()
        {
            Console.WriteLine("Encender");
        }
    }
}
