using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Supervisor:Empleado
    {
        string sueldoSup = "sueldoSup";
        string horaSup = "horarioSup";

        public string GetSueldo()
        {
            return sueldoSup;
        }
        public void SetSueldo(string horario)
        {
            this.sueldoSup = horario;
        }
        public string GetHora()
        {
            return horaSup;
        }
        public void SetHora(string horario)
        {
            this.horaSup = horario;
        }
    }
}
