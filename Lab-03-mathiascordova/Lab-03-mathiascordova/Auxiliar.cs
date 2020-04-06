using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Auxiliar:Empleado
    {
        private string sueldoAux = "sueldoAux";
        private string horaAux = "horarioAux";

        public string GetSueldo()
        {
            return sueldoAux;
        }
        public void SetSueldo(string sueldo)
        {
            this.sueldoAux = sueldo;
            setSueldo(sueldo);
        }
        public string GetHora()
        {
            return horaAux;
        }
        public void SetHora(string horario)
        {
            this.horaAux = horario;
            setHorario(horario);
        }
    }

}
