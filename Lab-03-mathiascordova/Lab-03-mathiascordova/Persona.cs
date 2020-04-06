using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_mathiascordova
{
    class Persona
    {
        protected List<String> Nombres = new List<String>() { "Cristina", "Mathias", "Maria Belen", "Kylian", "Agustin", "Charlotte", "Alvaro", "Diego", "Francisca", "Martina", "Sebastian", "Lorena", "Natalia", "Javier","Raul" };
        protected List<String> Apellidos = new List<String>() { "Sanchez", "Cordova", "Medel", "Mbappe", "Messi", "Jobs", "Soto", "Perez", "Rodriguez", "Fuentes", "Arriagada", "Howard", "Diaz", "Londra", "Ruiz" };
        protected List<String> Naciones = new List<String>() { "Chilena", "Argentina", "Francesa", "Alemana", "Gringa", "Italiana", "Coreana", "Venezolana", "Ecuatoriana", "Peruana", "Mexicana", "Venezolana", "Ecuatoriana", "Peruana", "Mexicana" };
        

        protected string RUT;
        

        protected string Nombre;
        

        protected string Apellido;
        

        protected string Fecha;
        

        protected string Nacion;

        




        public void setNomApeNac(int ale1,int ale2,int ale3,int dia,int mes,int ano)
        {
            
            this.Nombre = Nombres[ale1];                       
            this.Apellido = Apellidos[ale2];
            this.Nacion = Naciones[ale3];
            this.Fecha = dia.ToString() + "/" + mes.ToString() + "/" + ano.ToString();
            
            
        }
        public void setNombre(string Nombre,string Apellido,string Nacion,string RUT,List<int> Fecha)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nacion = Nacion;
            this.Fecha = Fecha[0].ToString() + "/" + Fecha[1].ToString() + "/" + Fecha[2].ToString();
            this.RUT = RUT;
        }


        public void setRUT(List<int> num) //NOTEMOS QUE ESTE METODO CREA RUT VALIDOS, APRECIEN LA DEDICACION//
        {

            int verificador = 0;
            int ponderador = 7;
            this.RUT += num[0].ToString()+num[1].ToString()+".";

            for (int i = 0; i < 6; i++)
            {
                this.RUT += num[i + 2].ToString();
                verificador += num[i + 2]*ponderador;
                if (i == 2)
                {
                    this.RUT += ".";
                }
                ponderador--;

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
        
        public string getNomApNac()
        {
            return this.Nombre + " " + this.Apellido + ", Nac.: "+ this.Fecha +", Pais: " + this.Nacion+ ", RUT: " + this.RUT;
        }
        public string getRUT()
        {
            return RUT;
        }
        public string soloNom()
        {
            return Nombre + " " + Apellido;
        }
        
    }  
}
