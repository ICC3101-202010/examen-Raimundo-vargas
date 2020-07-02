using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examen
{
    class Jugador : Persona
    {
        int Ataque;
        int Defensa;
        int Camiseta;
        string Nombre;
        string Nacion;
        int Sueldo;
        public Jugador(string nombre, string nacion, int sueldo, int ataque, int defensa, int camiseta) : base(nombre, nacion, sueldo)
        {
            Ataque = ataque;
            Defensa = defensa;
            Camiseta = camiseta;
            Nombre = nombre;
            Nacion = nacion;
            Sueldo = sueldo;
        }
        public override void Verinformacion()
        {
            Console.WriteLine("Nombre Jugador:");
            Console.WriteLine(Nombre);
            Console.WriteLine("Nacion Jugador:");
            Console.WriteLine(Nacion);
            Console.WriteLine("Numero de la camiseta del Jugador:");
            Console.WriteLine(Camiseta);
        }
    }
}
