using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Supermercado
    {
        List<Cliente> allClientes = new List<Cliente>();
        List<Object> allEmpleados = new List<Object>();
        List<Auxiliar> allCajeros = new List<Auxiliar>();
        List<Producto> allProductos = new List<Producto>();

        public void setClientes(Cliente cliente)
        {
            cliente.setNomApeNac();
            cliente.setRUT();
            cliente.setID();
            allClientes.Add(cliente);

        }
        public void setEmpleados(Object objeto)
        {
            allEmpleados.Add(objeto);
        }
        public void setCajeros(Auxiliar auxi)
        {
            allCajeros.Add(auxi);
        }
        public void setProductos(Producto producto)
        {
            allProductos.Add(producto);
        }
        public void getClientes()
        {
            for (int i = 0; i < allClientes.Count(); i++)
            {
                Console.WriteLine(allClientes[i].getNomApNac());
                
            }
        }
        public List<Producto>  getProductos()
        {
            return allProductos;
        }
        public void getCajeros()
        {
            for (int i =0; i < allCajeros.Count(); i++)
            {
                Console.WriteLine(allCajeros[i].getNomApNac());
            }
        }
    }
}
