using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta
{
    public class Producto
    {
        private int id;
        public string nom;
        public string categoria;
        public string precio;
        public string cantidad;
        public string descripcion;
        private int eliminado;

        public Producto(string nom, string cat, string precio, string cant, string desc) {
            this.nom = nom;
            this.categoria = cat;
            this.precio = precio;
            this.cantidad = cant;
            this.descripcion = desc;
        }


    }
}
