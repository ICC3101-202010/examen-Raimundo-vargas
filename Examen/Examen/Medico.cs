using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examen
{
    class Medico : Persona
    {

        int Experiencia;

        public Medico(string nombre, string nacion, int sueldo, int experiencia) : base(nombre, nacion, sueldo)
        {
            Experiencia = experiencia;
        }

        public override void Verinformacion()
        {
            Console.WriteLine("Nombre Medico:");
            Console.WriteLine(nombre);
            Console.WriteLine("Nacion Medico:");
            Console.WriteLine(nacion);
        }
    }
}
