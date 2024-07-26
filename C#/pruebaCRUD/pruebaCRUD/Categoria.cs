using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaCRUD
{
    public class Categoria
    {
        public string IdCategoria { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcionCategoria { get; set; }

        public Categoria(string idCategoria, string nombreCategoria, string descripcionCategoria)
        {
            IdCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;
        }

        public override string ToString() {
            return $"Categoria: {nombreCategoria}, Descripcion: {descripcionCategoria}";
        }
    }
}
