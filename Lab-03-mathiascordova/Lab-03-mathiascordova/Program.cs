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
            Console.WriteLine("BIENVENIDO AL SUPERMERCADO");
            Supermercado super = new Supermercado();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("ELIJA UNA DE LAS OPCIONES:");
                Console.WriteLine("");
                Console.WriteLine("1. PROGRAMA MANUAL{0}2. PROGRAMA AUTOMATICO (BONUS){0}X. SALIR", Environment.NewLine);

                string choice = Console.ReadLine();

                if (choice == "1")
                {

                }
                else if (choice == "2")
                {
                    Console.WriteLine("GENERANDO CLIENTES, EMPLEADOS Y PRODUCTOS...{0}ABRIENDO SUPERMERCADO...", Environment.NewLine);
                    int hora = 900;
           
                }
                else if (choice=="x"||choice=="X")
                {
                    Console.WriteLine("NOS VEMOS PRONTO!");
                    break;
                }
                else if (choice!="1"&& choice != "2" && choice != "x" && choice != "X")
                {
                    Console.WriteLine("LA ELECCION ES INVALIDA");
                    continue;
                }
            }
        }
    }
}
