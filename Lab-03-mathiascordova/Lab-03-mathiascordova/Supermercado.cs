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
        List<Producto> allCompras = new List<Producto>();

        public void setClientes(Cliente cliente)
        {
            
            
            allClientes.Add(cliente);

        }
        public void setEmpleados(Object persona)
        {
            allEmpleados.Add(persona);
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
            Console.WriteLine("");
        }
        public void GetProd()
        {
            for (int i = 0; i < allProductos.Count(); i++)
            {
                Console.WriteLine(allProductos[i].getDatos());
                Console.WriteLine("");
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
            Console.WriteLine("");
        }
        public List<Cliente> GetAllClientes()
        {
            return allClientes;
        }
        public List<Auxiliar> GetAllCajeros()
        {
            return allCajeros;
        }
        public List<Producto> GetAllProd()
        {
            return allProductos;
        }
        public void ResetAll()
        {
            allCajeros.Clear();
            allClientes.Clear();
            allCompras.Clear();
            allProductos.Clear();
            allEmpleados.Clear();
        }

    }
}
