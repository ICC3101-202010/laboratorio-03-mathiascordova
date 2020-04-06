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
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("");
                Console.WriteLine("ELIJA UNA DE LAS OPCIONES:");
                Console.WriteLine("");
                Console.WriteLine("1. PROGRAMA MANUAL{0}2. PROGRAMA AUTOMATICO (BONUS){0}X. SALIR", Environment.NewLine);
                Console.WriteLine("");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Random random = new Random();
                    super.ResetAll();
                    int Hora = 900;
                    int diap = random.Next(1, 29);
                    int mesp = random.Next(1, 13);
                    while (true)
                    {
                        
                        Console.WriteLine("ELIJA UNA DE LAS SGTES OPCIONES:{0}1. CREAR CLIENTE{0}2. CREAR JEFE{0}3. CREAR CAJERO{0}4. CREAR SUPERVISOR{0}5. GENERAR PRODUCTOS{0}6. REALIZAR COMPRA CON CLIENTE ALEATORIO{0}7. VER PERSONAS Y PRODUCTOS{0}X. VOLVER AL MENU", Environment.NewLine);
                        Console.WriteLine("");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "x" || choice2 == "X")
                        {
                            break;
                        }
                        else if (choice2 == "1")
                        {
                            Cliente cliente = new Cliente();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL CLIENTE");
                            string Nombre = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string Apellido= Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string Nacion=Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string RUT= Console.ReadLine();
                            Console.WriteLine("INGRESE SU DIA DE NACIMIENTO (EJ.: 15):");
                            List<int> Fecha = new List<int>();
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU MES DE NACIMIENTO (EJ.: JULIO = 7)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO (EJ.: 1999)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            cliente.setNombre(Nombre, Apellido, Nacion, RUT, Fecha);
                            cliente.setID(random.Next(10), random.Next(10), random.Next(10));
                            super.setClientes(cliente);
                            Console.WriteLine("");
                            Console.WriteLine("_________________________________________________________________");
                        }
                        else if (choice2 == "2")
                        {
                            Jefe jefe = new Jefe();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL JEFE");
                            string Nombre = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string Apellido = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string Nacion = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string RUT = Console.ReadLine();
                            Console.WriteLine("INGRESE SU DIA DE NACIMIENTO (EJ.: 15):");
                            List<int> Fecha = new List<int>();
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU MES DE NACIMIENTO (EJ.: JULIO = 7)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO (EJ.: 1999)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            jefe.setNombre(Nombre, Apellido, Nacion, RUT, Fecha);
                            jefe.SetSueldo("SueldoJefe");
                            jefe.SetHora("HorarioJefe");
                            super.setEmpleados(jefe);
                            Console.WriteLine("");
                            Console.WriteLine("_________________________________________________________________");
                        }
                        else if (choice2 == "3")
                        {
                            Auxiliar cajero = new Auxiliar();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL CAJERO");
                            string Nombre = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string Apellido = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string Nacion = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string RUT = Console.ReadLine();
                            Console.WriteLine("INGRESE SU DIA DE NACIMIENTO (EJ.: 15):");
                            List<int> Fecha = new List<int>();
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU MES DE NACIMIENTO (EJ.: JULIO = 7)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO (EJ.: 1999)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            cajero.setNombre(Nombre, Apellido, Nacion, RUT, Fecha);
                            cajero.SetSueldo("SueldoCajero");
                            cajero.SetHora("HorarioCajero");
                            super.setEmpleados(cajero);
                            super.setCajeros(cajero);
                            Console.WriteLine("");
                            Console.WriteLine("_________________________________________________________________");
                        }
                        else if (choice2 == "4")
                        {
                            Supervisor sup = new Supervisor();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL SUPERVISOR");
                            string Nombre = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string Apellido = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string Nacion = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string RUT = Console.ReadLine();
                            Console.WriteLine("INGRESE SU DIA DE NACIMIENTO (EJ.: 15):");
                            List<int> Fecha = new List<int>();
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU MES DE NACIMIENTO (EJ.: JULIO = 7)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO (EJ.: 1999)");
                            Fecha.Add(Int32.Parse(Console.ReadLine()));
                            sup.setNombre(Nombre, Apellido, Nacion, RUT, Fecha);
                            sup.SetSueldo("SueldoCajero");
                            sup.SetHora("HorarioCajero");
                            super.setEmpleados(sup);
                            Console.WriteLine("");
                            Console.WriteLine("_________________________________________________________________");
                        }
                        else if (choice2 == "5")
                        {
                            Console.WriteLine("INGRESE EL NUMERO DE PRODUCTOS QUE QUIERE GENERAR:");
                            int num = Int32.Parse(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                int ale1 = random.Next(15);
                                int ale2 = random.Next(15);
                                int ale3 = random.Next(15);
                                int ale4 = random.Next(1, 5);
                                
                                Producto producto = new Producto();
                                producto.generarProducto(ale1, ale2, ale3, ale4, diap, mesp);
                                super.setProductos(producto);
                            }
                        }
                        else if (choice2 == "6")
                        {
                            List<Cliente> allClientes = super.GetAllClientes();
                            List<Auxiliar> allCajeros = super.GetAllCajeros();
                            List<Producto> allProd = super.GetAllProd();
                            if (allClientes.Count() == 0 || allCajeros.Count() == 0 || allProd.Count() == 0)
                            {
                                Console.WriteLine("ES IMPOSIBLE REALIZAR LA COMPRA PORQUE FALTAN CLIENTES Y/O CAJEROS Y/O PRODUCTOS");
                                Console.WriteLine("");
                                continue;
                            }
                            else
                            {
                                List<Producto> compras = new List<Producto>();
                                int randCliente = random.Next(allClientes.Count());
                                int randCajero = random.Next(allCajeros.Count());
                                Console.WriteLine("INGRESE EL NUMERO DE PRODUCTOS A COMPRAR");
                                int numCompras = Int32.Parse(Console.ReadLine());
                                for (int a = 0; a < numCompras; a++)
                                {
                                    int randCompra = random.Next(allProd.Count());
                                    int stock = allProd[randCompra].checkStock();
                                    if (stock <= 0)
                                    {
                                        allProd.RemoveAt(randCompra);
                                        
                                    }
                                    else
                                    {
                                        allProd[randCompra].hacerCompra(allClientes[randCliente], allCajeros[randCajero], Hora);
                                        compras.Add(allProd[randCompra]);
                                        Console.WriteLine(compras[(compras.Count() - 1)].getDatosCompra());
                                        Console.WriteLine("");
                                    }
                                }
                                int cambioHora = random.Next(2);
                                if (cambioHora == 0)
                                {
                                    Hora += 100;
                                }
                                else
                                {
                                    Hora += 10;
                                }
                                Console.WriteLine("");
                                Console.WriteLine("_________________________________________________________________");

                            }
                        }
                        else if (choice2 == "7")
                        {
                            List<Cliente> allClientes = super.GetAllClientes();
                            List<Auxiliar> allCajeros = super.GetAllCajeros();
                            List<Producto> allProd = super.GetAllProd();
                            if (allClientes.Count() == 0 || allCajeros.Count() == 0 || allProd.Count() == 0)
                            {
                                Console.WriteLine("ES IMPOSIBLE MOSTRAR LOS DATOS PORQUE FALTAN CLIENTES Y/O CAJEROS Y/O PRODUCTOS");
                                Console.WriteLine("");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("CLIENTES:");
                                Console.WriteLine("");
                                super.getClientes();
                                Console.WriteLine("CAJEROS:");
                                Console.WriteLine("");
                                super.getCajeros();
                                Console.WriteLine("PRODUCTOS:");
                                Console.WriteLine("");
                                super.GetProd();
                            }
                        }
                        else if (choice2!="1"&&choice2!="2" && choice2 != "3" && choice2 != "4" && choice2 != "5" && choice2 != "6" && choice2 != "7" && choice2 != "x" && choice2 != "X")
                        {
                            Console.WriteLine("SU ELECCION ES INVALIDA! SELECCIONE OTRA.");
                            Console.WriteLine("");
                            Console.WriteLine("_________________________________________________________________");
                            continue;
                        }
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("PREPARANDO PROGRAMA AUTOMATICO...{0}CREANDO CLIENTES, STAFF Y PRODUCTOS...{0}REALIZANDO COMPRAS...", Environment.NewLine);
                    Random random = new Random();
                    super.ResetAll();
                    int Hora = 900;
                    int diap = random.Next(1, 29);
                    int mesp = random.Next(1, 13);
                    Console.WriteLine("_________________________________________________________________");
                    for (int i = 0; i < 17; i++)
                    {
                        
                        int ale1 = random.Next(15);
                        int ale2 = random.Next(15);
                        int ale3 = random.Next(15);
                        int dia = random.Next(1, 29);
                        int mes = random.Next(1, 13);
                        int ano = random.Next(1950, 2013);
                        List<int> numRUT = new List<int>();
                        for (int a = 0; a < 8; a++)
                        {
                            if (a == 0)
                            {                               
                                numRUT.Add(random.Next(0, 3));
                                if (numRUT[0] == 0)
                                {
                                    numRUT.Add(random.Next(5, 10));
                                }
                                else if (numRUT[0] == 1)
                                {
                                    numRUT.Add(random.Next(10));
                                }
                                else
                                {
                                    numRUT.Add(random.Next(6));
                                }

                            }
                            else
                            {
                                numRUT.Add(random.Next(10));
                            }
                        }
                        if (i < 15)
                        {
                            Cliente cliente = new Cliente();
                            cliente.setNomApeNac(ale1, ale2, ale3,dia,mes,ano);
                            cliente.setRUT(numRUT);
                            cliente.setID(ale1,ale2,ale3);
                            super.setClientes(cliente);
                        }
                        if (i == 15)
                        {
                            Jefe jefe = new Jefe();
                            jefe.setNomApeNac(ale1,ale2,ale3,dia,mes,ano);
                            jefe.setRUT(numRUT);
                            super.setEmpleados(jefe);
                            
                        }
                        else if (i == 16)
                        {
                            Auxiliar cajero = new Auxiliar();
                            cajero.setNomApeNac(ale1,ale2,ale3,dia,mes,ano);
                            cajero.setRUT(numRUT);
                            super.setEmpleados(cajero);
                            super.setCajeros(cajero);
                        }
                        
                    }
                    
                    
                    for (int i = 0; i < 5; i++)
                    {
                        
                        int aleatorio = random.Next(0, 2);
                        int ale1 = random.Next(15);
                        int ale2 = random.Next(15);
                        int ale3 = random.Next(15);
                        int dia = random.Next(1,29);
                        int mes = random.Next(1, 13);
                        int ano = random.Next(1950, 2013);
                        List<int> numRUT = new List<int>();
                        for (int a = 0; a < 8; a++)
                        {
                            if (a == 0)
                            {
                                numRUT.Add(random.Next(0, 3));
                                if (numRUT[0] == 0)
                                {
                                    numRUT.Add(random.Next(5, 10));
                                }
                                else if (numRUT[0] == 1)
                                {
                                    numRUT.Add(random.Next(10));
                                }
                                else
                                {
                                    numRUT.Add(random.Next(6));
                                }

                            }
                            else
                            {
                                numRUT.Add(random.Next(10));
                            }
                        }
                        if (aleatorio == 0)
                        {

                            Auxiliar auxiliar = new Auxiliar();
                            auxiliar.setNomApeNac(ale1, ale2, ale3,dia,mes,ano);
                            auxiliar.setRUT(numRUT);
                            super.setEmpleados(auxiliar);
                            super.setCajeros(auxiliar);

                        }
                        else
                        {
                            Supervisor sup = new Supervisor();
                            sup.setNomApeNac(ale1, ale2, ale3, dia, mes, ano);
                            sup.setRUT(numRUT);
                            super.setEmpleados(sup);
                        }
                    }
                    
                    for (int i = 0; i < 30; i++)
                    {
                        int ale1 = random.Next(15);
                        int ale2= random.Next(15);
                        int ale3 = random.Next(15);
                        int ale4 = random.Next(1,5);
                        
                        Producto producto = new Producto();
                        producto.generarProducto(ale1, ale2, ale3, ale4,diap,mesp);
                        super.setProductos(producto);
                    }
                    List<Cliente> allClientes = super.GetAllClientes();
                    List<Auxiliar> allCajeros = super.GetAllCajeros();
                    List<Producto> allProductos = super.GetAllProd();
                    for (int x = 0; x < 5; x++)
                    {
                        List<Producto> compras = new List<Producto>();
                        int randCliente = random.Next(allClientes.Count());
                        int randCajero = random.Next(allCajeros.Count());
                        int numCompras=random.Next(1, 5);
                        Console.WriteLine("COMPRA DEL DIA NRO.: "+ (x+1));
                        Console.WriteLine("");
                        for (int a = 0; a < numCompras; a++)
                        {
                            int randCompra = random.Next(allProductos.Count());
                            int stock = allProductos[randCompra].checkStock();
                            if (stock <= 0)
                            {
                                allProductos.RemoveAt(randCompra);
                                
                            }
                            else if (stock>0)
                            {
                                allProductos[randCompra].hacerCompra(allClientes[randCliente], allCajeros[randCajero], Hora);                               
                                compras.Add(allProductos[randCompra]);
                                Console.WriteLine(compras[(compras.Count()-1)].getDatosCompra());
                                Console.WriteLine("");
                            }
                        }
                        int cambioHora = random.Next(2);
                        if (cambioHora == 0)
                        {
                            Hora += 100;
                        }
                        else
                        {
                            Hora += 10;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("_________________________________________________________________");
                    }
                    



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
