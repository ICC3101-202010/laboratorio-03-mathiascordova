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
        private Cliente Cliente;
        private Auxiliar Cajero;
        private int Hora;
        private string Fecha = "7 de abril 2020";

        private List<string> allNombre = new List<string>() { "Carne", "Atun", "Vino", "Galletas", "Aceitunas", "Queso", "Yogurt", "Pan", "Helado", "Jamon", "Bebida", "Tomate", "Pan", "Arroz", "Dulces" };
        private List<string> allMarcas = new List<string>() { "Great Value", "Fruna", "Bimbo", "Mackay", "Nestle", "Carozzi", "Maggi", "Jumbo", "Ambrosoli" };
        private List<string> allPrecios = new List<string>() { "500", "750", "1000", "1100", "900", "2000", "1500", "2700", "3000" };
        Random random = new Random();
        public void generarProducto()
        {
            
            this.Nombre = allNombre[random.Next(0, allNombre.Count())];
            this.Precio = allPrecios[random.Next(0, allPrecios.Count())];
            this.Marca = allMarcas[random.Next(0, allMarcas.Count())];
            this.Stock = random.Next(1, 5);

        }
        public string hacerCompra(Cliente persona,Auxiliar empleado,int hora)
        {
            if (Stock <= 0){
                return "No fue posible realizar la compra de " + Nombre + " " + Marca;

            }
            else
            {
                Stock--;
                this.Cliente = persona;
                this.Cajero = empleado;
                this.Hora = hora;
                return "Se compra " + Nombre + " " + Marca;
            }
        }
        public string getDatos()
        {
            return Nombre + " " + Marca;
            //return Nombre + " " + Marca + ",Cliente: " + Cliente.getNomApNac() + " " + Cliente.getRUT() + " " + Cliente.getID() + ", Cajero: " + Cajero.getNomApNac() + ", Fecha y Hora: "+Fecha+" "+Hora.ToString();//
        }
    }
}
