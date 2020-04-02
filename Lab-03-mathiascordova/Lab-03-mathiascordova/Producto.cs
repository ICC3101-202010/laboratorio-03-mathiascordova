using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Producto
    {
        private string Nombre;
        private string Precio;
        private string Marca;
        private int Stock;
        public Producto(string nombre, string precio,string marca,int stock)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
            this.Stock = stock;
        }
    }
}
