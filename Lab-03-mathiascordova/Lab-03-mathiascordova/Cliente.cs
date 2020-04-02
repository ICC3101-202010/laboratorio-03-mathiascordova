using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Cliente: Persona
    {
        private string clientID;
        private List<Producto> compras = new List<Producto>();
        private string horarioCompra;

        public void setID()
        {
            Random random = new Random();
            string unidad = random.Next(10).ToString();
            string decena = random.Next(10).ToString();
            string centena= random.Next(10).ToString();
            this.clientID = "clientID: " + unidad + decena + centena;
        }
        public string getID()
        {
            return clientID;
        }
        public void setHorario(string horario)
        {
            this.horarioCompra = horario;
        }
        public string getHorario()
        {
            return horarioCompra;
        }
    }
}
