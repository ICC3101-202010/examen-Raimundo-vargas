using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examen
{
    class Equipo
    {
        public string nombre;
        public string tipo;
        public List<Jugador> Jugadores = new List<Jugador>();
        public List<Entrenador> Entrenador = new List<Entrenador>();
        public List<Medico> Medico = new List<Medico>();
        

        public Equipo(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public void crear_Entrenador(string nombre, string nacion, int sueldo, int tactica)
        {
            Entrenador.Add(new Entrenador(nombre,nacion,sueldo,tactica));
        }
        public void crear_medico(string nombre, string nacion, int sueldo, int experiencia)
        {
            Medico.Add(new Medico(nombre, nacion, sueldo, experiencia));
        }
        public void Agregar_Jugador(string nombre, string nacion, int sueldo, int ataque, int defensa, int camiseta)
        {
            Jugadores.Add(new Jugador(nombre,nacion,sueldo,ataque,defensa,camiseta));
        }


        public void Ver_Info_equipo()
        {
            Console.WriteLine("\nNombre Equipo:\n");
            Console.WriteLine(nombre);
            Thread.Sleep(1000);

            Console.WriteLine("\nTipo de Equipo:\n");
            Console.WriteLine(tipo);
            Thread.Sleep(1000);


            Console.WriteLine("\nEntrenador:\n");
            Entrenador[0].Verinformacion();
            Thread.Sleep(1000);

            Console.WriteLine("\nMedico:\n");
            Medico[0].Verinformacion();
            Thread.Sleep(1000);

            int n = 1;
            foreach (Jugador j in Jugadores)
            {
                Console.WriteLine("\nJugador n "+n+":\n");
                j.Verinformacion();
                Thread.Sleep(1000);
                n += 1;
            }
            Console.WriteLine("\nEsa es la informacion del equipo completo, presione cualquier tecla para salir\n");
            Console.ReadLine();

        }

    }
}
