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

        public Entrenador(string nombre, string nacion, int sueldo, int tactica) : base(nombre, nacion, sueldo)
        {
            Tactica = tactica;
        }
        
        public override void Verinformacion()
        {
            Console.WriteLine("Nombre Entrenador:");
            Console.WriteLine(nombre);
            Console.WriteLine("Nacion Entrenador:");
            Console.WriteLine(nacion);
        }
    }
}
