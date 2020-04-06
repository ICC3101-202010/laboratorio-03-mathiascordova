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
        private string Fecha;

        private List<string> allNombre = new List<string>() { "Carne", "Atun", "Vino", "Galletas", "Aceitunas", "Queso", "Yogurt", "Pan", "Helado", "Jamon", "Bebida", "Tomate", "Pan", "Arroz", "Dulces" };
        private List<string> allMarcas = new List<string>() { "Great Value", "Fruna", "Bimbo", "Mackay", "Nestle", "Carozzi", "Maggi", "Jumbo", "Ambrosoli" ,"Ferrero", "Soprole", "Danone", "Sopraval", "Not CO.", "Colun" };
        private List<string> allPrecios = new List<string>() { "500", "750", "1000", "1100", "900", "2000", "1500", "2700", "3000", "550", "600", "950", "1250", "2100", "2200" };
        
        public void generarProducto(int ale1,int ale2,int ale3,int stock,int dia,int mes)
        {
            
            this.Nombre = allNombre[ale1];
            this.Precio = allPrecios[ale2];
            this.Marca = allMarcas[ale3];
            this.Stock = stock;
            this.Fecha=dia.ToString()+"/"+mes.ToString()+"/" + "2020";
        }
        public void hacerCompra(Cliente persona,Auxiliar empleado,int hora)
        {
            if (Stock <= 0)
            {
                Console.WriteLine("No fue posible realizar la compra");

            }
            else
            {
                Stock--;
                this.Cliente = persona;
                this.Cajero = empleado;
                this.Hora = hora;
                
            }
        }
        public string getDatos()
        {            
            return "Nombre: " + Nombre+Environment.NewLine + "Marca: " + Marca +Environment.NewLine+ "Stock: " + Stock;
        }
        public string getDatosCompra()
        {
            
            return Nombre + " " + Marca +Environment.NewLine +"Cliente: " + Cliente.soloNom()  + Environment.NewLine+"Cajero: " + Cajero.soloNom() + Environment.NewLine + "Fecha: "+Fecha+Environment.NewLine+"Hora: "+Hora.ToString()+ Environment.NewLine + "Stock despues de compra: "+ Stock.ToString();
        }
        public int checkStock()
        {
            return Stock;
        }
        
    }
}
