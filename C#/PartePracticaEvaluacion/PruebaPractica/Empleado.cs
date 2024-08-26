using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractica
{
    public class Empleado : Persona, ICalculable
    {
        public int DiasTrabajados { get; set; }
        public decimal ValorDia { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string namePersona,int telefono, int agePersona, string addressPersona, int diasTrabajados)
            : base( namePersona, telefono, agePersona, addressPersona)
        {
            DiasTrabajados = diasTrabajados;
            ValorDia = 1300000m;
            Salario = CalcularSalario();
        }

        public decimal CalcularSalario()
        {
            decimal salarioCalculado = (ValorDia / 30) * DiasTrabajados;
            return Math.Round(salarioCalculado, 2);
        }

        public override void InfoPersona()
        {
            base.InfoPersona();
            Console.WriteLine($"Salario: {Salario:F2}");
        }
    }
}
