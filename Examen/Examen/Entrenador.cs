using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examen
{
    class Entrenador : Persona
    {
        int Tactica;
        string Nombre;
        string Nacion;
        int Sueldo;

        public Entrenador(string nombre, string nacion, int sueldo, int tactica) : base(nombre, nacion, sueldo)
        {
            Tactica = tactica;
            Nombre = nombre;
            Nacion = nacion;
            Sueldo = sueldo;
        }
        
        public override void Verinformacion()
        {
            Console.WriteLine("Nombre Entrenador:");
            Console.WriteLine(Nombre);
            Console.WriteLine("Nacion Entrenador:");
            Console.WriteLine(Nacion);
        }
    }
}
