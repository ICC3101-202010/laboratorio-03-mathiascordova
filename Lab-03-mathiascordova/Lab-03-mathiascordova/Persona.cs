using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Persona
    {
        private string RUT;
        //public string _RUT { get => RUT; set => RUT = value; }//

        private string Nombre;
        

        private string Apellido;
        

        private string Fecha;
        //public string _Fecha { get => Fecha; set => Fecha = value; }//

        private string Nacion;
        



        protected List<String> Nombres = new List<String>() { "Natalia", "Mathias", "Maria Belen", "Kylian", "Agustin", "Charlotte" };
        protected List<String> Apellidos = new List<String>() {"Sanchez","Cordova","Medel","Mbappe","Messi","Jobs" };
        protected List<String> Naciones = new List<String>() { "Chilena", "Argentina", "Francesa", "Alemana", "Gringa", "Italiana", "Coreana" };

        public void setNomApeNac()
        {
            Random random = new Random();
            int ale1 = random.Next(0, Nombres.Count());
            int ale2 = random.Next(0, Apellidos.Count());
            int ale3 = random.Next(0, Naciones.Count());
            this.Nombre = Nombres[ale1];
            this.Apellido = Apellidos[ale2];
            this.Nacion = Naciones[ale3];
        }

        public void setRUT()
        {
            Random random = new Random();
            int verificador = 0;
            int n1 = random.Next(0, 3);
            if (n1 == 0)
            {
                this.RUT += n1.ToString();
                int n2 = random.Next(5, 10);
                verificador += n2 * 2;
                this.RUT += n2.ToString();
            }
            if (n1 == 1)
            {
                this.RUT += n1.ToString();
                verificador += n1 * 3;
                int n2 = random.Next(0, 10);
                verificador += n2 * 2;
                this.RUT += n2.ToString();
            }
            else if (n1 == 2)
            {
                this.RUT += n1.ToString();
                verificador += n1 * 3;
                int n2 = random.Next(0, 4);
                verificador += n2 * 2;
                this.RUT += n2.ToString();
            }
            int constante = 7;
            for (int i=0; i < 6; i++)
            {
                int n = random.Next(0, 10);
                verificador += n * constante;
                this.RUT += n.ToString();
                constante -= 1;
            }
            int guion =11 - verificador % 11;
            if (guion > 9)
            {
                this.RUT += "-K";
            }
            else if (guion < 0)
            {
                this.RUT += "-0";
            }
            else
            {
                this.RUT += "-" + guion.ToString();
            }

            
        }
        public string getRUT()
        {
            return RUT;
        }
        public string getNomApNac()
        {
            return Nombre + " " + Apellido + ", " + Nacion;
        }
    }  
}
