using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaCRUD
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public decimal Precio { get; set; }

        //relacion con la categoria
        private Categoria Categoria { get; set; }

        // Metodo Constructor
        public Producto(string id, string nombre, string descripcion, decimal precio,Categoria categoria)
        {
            IdProducto = id;
            nombreProducto = nombre;
            descripcionProducto = descripcion;
            Precio = precio;
            Categoria = categoria;

        }

        public override string ToString()//Hace que devuelva nombre y descripcion
        {
            return $"Producto: {nombreProducto}, Descripcion: {descripcionProducto}";
        }
    }
}
