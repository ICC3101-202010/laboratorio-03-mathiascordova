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

        public void setID(int unidad, int decena, int centena)
        {            
            this.clientID = "clientID: " + unidad.ToString() + decena.ToString() + centena.ToString();
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
