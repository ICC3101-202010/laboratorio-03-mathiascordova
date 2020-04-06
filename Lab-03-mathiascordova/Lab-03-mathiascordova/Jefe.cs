using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Jefe:Empleado
    {
        string sueldoJefe = "sueldoJefe";
        string horaJefe = "horarioJefe";

        public string GetSueldo()
        {
            return sueldoJefe;
        }
        public void SetSueldo(string sueldo)
        {
            this.sueldoJefe = sueldo;
            setSueldo(sueldo);
        }
        public string GetHora()
        {
            return horaJefe;
        }
        public void SetHora(string horario)
        {
            this.horaJefe = horario;
            setHorario(horario);
        }
    }
}
