using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Empleado: Persona
    {
        protected string Sueldo;
        protected string Horario;
        public void setSueldo(string Sueldo)
        {
            this.Sueldo = Sueldo;
            
        }
        public void setHorario(string Horario)
        {
            this.Horario = Horario;
        }
        public string getSueldo()
        {
            return Sueldo;
        }
        public string getHorario()
        {
            return Horario;
        }

    }
    
}
