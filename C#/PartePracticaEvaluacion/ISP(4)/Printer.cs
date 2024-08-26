using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_4_
{
    public class Printer : IPrinter
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo...");
        }
    }
}
