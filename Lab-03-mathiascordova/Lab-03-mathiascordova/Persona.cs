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
        

        private string Nombre;
        

        private string Apellido;
        

        private string Fecha;
        

        private string Nacion;
        



        protected List<String> Nombres = new List<String>() { "Cristina", "Mathias", "Maria Belen", "Kylian", "Agustin", "Charlotte", "Alvaro","Diego","Francisca","Martina","Sebastian","Lorena","Natalia"};
        protected List<String> Apellidos = new List<String>() {"Sanchez","Cordova","Medel","Mbappe","Messi","Jobs" ,"Soto", "Perez", "Rodriguez", "Fuentes", "Arriagada", "Howard", "Diaz", "Londra", "Ruiz", "Tagle" };
        protected List<String> Naciones = new List<String>() { "Chilena", "Argentina", "Francesa", "Alemana", "Gringa", "Italiana", "Coreana", "Venezolana", "Ecuatoriana", "Peruana", "Mexicana" };

        public void setNomApeNac()
        {
            Random random = new Random();
            int ale1 = random.Next(0, Nombres.Count());
            int ale2 = random.Next(0, Apellidos.Count());
            int ale3 = random.Next(0, Naciones.Count());
            int dia = random.Next(1, 29);
            int mes = random.Next(1, 13);
            int ano = random.Next(1930, 2015);

            this.Nombre = Nombres[ale1];
            this.Apellido = Apellidos[ale2];
            this.Nacion = Naciones[ale3];
            this.Fecha = dia.ToString() + "/" + mes.ToString() + "/" + ano.ToString();
            
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
            return Nombre + " " + Apellido + ", "+Fecha+" " + Nacion+" "+RUT;
        }
    }  
}
