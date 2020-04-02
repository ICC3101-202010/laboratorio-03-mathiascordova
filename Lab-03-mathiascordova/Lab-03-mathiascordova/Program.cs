using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.setID();
            Console.WriteLine(cliente.getID());
            cliente.setNomApeNac();
            cliente.setRUT();
            Console.WriteLine(cliente.getNomApNac());
            Console.WriteLine(cliente.getRUT());
            

        }
    }
}
