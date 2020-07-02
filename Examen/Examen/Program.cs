using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Procederemos a crear un nuevo equipo...\n");
            Thread.Sleep(1000);
            Console.WriteLine("Ingrese el nombre del equipo:");
            string nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese Tipo de equipo");
            Console.WriteLine("1. Liga");
            Console.WriteLine("2. Nacional\n");
            string tipo="";
            string nacion_jugador="";
            string respuesta;
            while (tipo!= "Nacional" && tipo != "Liga")
            {

                respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    case "1":
                        {
                            tipo = "Liga";
                            break;
                        }
                    case "2":
                        {
                            tipo = "Nacional";
                            Console.WriteLine("\nIngrese la nacion:");
                            nacion_jugador = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ingrese un tipo valido");
                            break;
                        }
                }
            }
            Equipo equipo = new Equipo(nombre,tipo);
            Console.WriteLine("\nCrearemos ahora al entrenador\n");
            Thread.Sleep(1000);
            //string nombre, string nacion, int sueldo, int tactica
            Console.WriteLine("Ingrese nombre del entrenador:");
            string nombre_entrenador = Console.ReadLine();
            Console.WriteLine("\nIngrese la nacion del entrenador:");
            string nacion_entrenador = Console.ReadLine();
            Console.WriteLine("\nIngrese el sueldo del entrenador(int):");
            int sueldo_entrenador=0;
            string funko = "no";
            while(funko!="si")
            {
                try
                {
                    sueldo_entrenador = int.Parse(Console.ReadLine());
                    funko = "si";
                }
                catch
                {
                    Console.WriteLine("\nIngreso un string, el sueldo debe ser int, ingrese nuevamente: ");
                    Thread.Sleep(1000);
                }
            }
            
            Console.WriteLine("\nIngrese los puntos de tactica del entrenador (del 0 al 100):");
            int puntos_entrenador=0;
            funko = "no";
            while (funko != "si")
            {
                try
                {
                    
                    puntos_entrenador = int.Parse(Console.ReadLine());
                    if (100 >= puntos_entrenador && puntos_entrenador >= 0)
                    {
                        funko = "si";
                    }
                    else
                    {
                        
                        Console.WriteLine("\nDebe ingresar algun numero valido entre 0 y 100, ingrese nuevamente:");
                    }
                        
                }
                catch
                {
                    Console.WriteLine("\nIngreso un string, los puntos de tactica debe ser int, ingrese nuevamente:");
                    Thread.Sleep(1000);
                }
            }
            equipo.crear_Entrenador(nombre_entrenador, nacion_entrenador, sueldo_entrenador, puntos_entrenador);
            Console.WriteLine("Entrenador creado de forma correcta\n");
            Thread.Sleep(1000);

            Console.WriteLine("\nCrearemos ahora al Medico\n");
            Thread.Sleep(1000);
            //string nombre, string nacion, int sueldo, int tactica
            Console.WriteLine("Ingrese nombre del Medico:");
            string nombre_medico = Console.ReadLine();
            Console.WriteLine("\nIngrese la nacion del Medico:");
            string nacion_medico = Console.ReadLine();
            Console.WriteLine("\nIngrese el sueldo del Medico(int):");
            int sueldo_medico = 0;
            funko = "no";
            while (funko != "si")
            {
                try
                {
                    sueldo_medico = int.Parse(Console.ReadLine());
                    funko = "si";
                }
                catch
                {
                    Console.WriteLine("\nIngreso un string, el sueldo debe ser int, ingrese nuevamente: ");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine("\nIngrese los puntos de experiencia del Medico (del 0 al 100):");
            int puntos_medico = 0;
            funko = "no";
            while (funko != "si")
            {
                try
                {

                    puntos_medico = int.Parse(Console.ReadLine());
                    if (100 >= puntos_medico && puntos_medico >= 0)
                    {
                        funko = "si";
                    }
                    else
                    {

                        Console.WriteLine("\nDebe ingresar algun numero valido entre 0 y 100, ingrese nuevamente:");
                    }

                }
                catch
                {
                    Console.WriteLine("\nIngreso un string, los puntos de experiencia debe ser int, ingrese nuevamente:");
                    Thread.Sleep(1000);
                }
            }

            equipo.crear_medico(nombre_medico, nacion_medico, sueldo_medico, puntos_medico);
            Console.WriteLine("Medico creado de forma correcta\n");
            Thread.Sleep(1000);



            Console.WriteLine("\nPasaremos ahora a crear los Jugadores, si elegiste un equipo de tipo nacional no te pediremos ingresar este dato debido a que todos los jugadores deben ser de la misma nacion.\n");
            //string nombre, string nacion, int sueldo, int ataque, int defensa, int camiseta
            string nombre_jugador="";
            int sueldo_jugador=0;
            int ataque_jugador=0;
            int defensa_jugador=0;
            int camiseta=0;




            int n=0;
            while (n < 15)
            {
                int r = n + 1;
                Console.WriteLine("Ingrese Nombre del Jugador n "+ r +":");
                nombre_jugador = Console.ReadLine();

                Console.WriteLine("Ingrese Sueldo del Jugador:");
                funko = "no";
                while (funko != "si")
                {
                    try
                    {
                        sueldo_jugador = int.Parse(Console.ReadLine());
                        funko = "si";
                    }
                    catch
                    {
                        Console.WriteLine("\nIngreso un string, el sueldo debe ser int, ingrese nuevamente:");
                        Thread.Sleep(1000);
                    }
                }

                Console.WriteLine("Ingrese Puntos de ataque del Jugador (del 0 al 100):");
                funko = "no";
                while (funko != "si")
                {
                    try
                    {

                        ataque_jugador = int.Parse(Console.ReadLine());
                        if (100 >= ataque_jugador && ataque_jugador >= 0)
                        {
                            funko = "si";
                        }
                        else
                        {

                            Console.WriteLine("\nDebe ingresar algun numero valido entre 0 y 100, ingrese nuevamente:");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("\nIngreso un string, los puntos de ataque debe ser int, ingrese nuevamente:");
                        Thread.Sleep(1000);
                    }
                }

                Console.WriteLine("Ingrese Puntos de defensa del Jugador (del 0 al 100):");
                funko = "no";
                while (funko != "si")
                {
                    try
                    {

                        defensa_jugador = int.Parse(Console.ReadLine());
                        if (100 >= defensa_jugador && defensa_jugador >= 0)
                        {
                            funko = "si";
                        }
                        else
                        {
                            Console.WriteLine("\nDebe ingresar algun numero valido entre 0 y 100, ingrese nuevamente:");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("\nIngreso un string, los puntos de defensa debe ser int, ingrese nuevamente:");
                        Thread.Sleep(1000);
                    }
                }

                Console.WriteLine("Ingrese numero de camiseta del Jugador (del 0 al 100):");
                funko = "no";
                while (funko != "si")
                {
                    try
                    {

                        camiseta = int.Parse(Console.ReadLine());
                        if (100 >= camiseta && camiseta >= 0)
                        {
                            funko = "si";
                        }
                        else
                        {
                            Console.WriteLine("\nDebe ingresar algun numero valido entre 0 y 100, ingrese nuevamente:");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("\nIngreso un string, el numero de la camiseta debe ser int, ingrese nuevamente:");
                        Thread.Sleep(1000);
                    }
                }
                
                
                if (equipo.tipo == "Nacional")
                {
                    equipo.Jugadores.Add(new Jugador(nombre_jugador, nacion_jugador, sueldo_jugador, ataque_jugador, defensa_jugador, camiseta));
                    Console.WriteLine("\nJugador creado correctamente\n");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Ingrese la nacion:");
                    nacion_jugador = Console.ReadLine();
                    equipo.Jugadores.Add(new Jugador(nombre_jugador, nacion_jugador, sueldo_jugador, ataque_jugador, defensa_jugador, camiseta));
                    Console.WriteLine("\nJugador creado correctamente\n");
                    Thread.Sleep(1000);
                }
                n += 1;
            }
            Console.WriteLine("\nJugadores agregados de forma correcta...");
            Thread.Sleep(1000);
            Console.WriteLine("\nEl equipo ya esta creado al 100%");
            Thread.Sleep(1000);
            Console.WriteLine("\nDesea ahora ver la informacion del equipo o salir?");
            Console.WriteLine("1. Ver Informacion");
            Console.WriteLine("2. Salir");
            respuesta = Console.ReadLine();


            while (respuesta!="2")
            {

                
                switch (respuesta)
                {
                    case "1":
                        {
                            equipo.Ver_Info_equipo();
                            respuesta = "2";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ingrese una opcion valida");
                            respuesta = Console.ReadLine();
                            break;
                        }
                }
            }
            Console.WriteLine("\nHasta pronto...");
            Thread.Sleep(1000);

        }
    }
}
