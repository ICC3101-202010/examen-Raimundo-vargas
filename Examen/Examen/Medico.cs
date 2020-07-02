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
        string Nombre;
        string Nacion;
        int Sueldo;

        public Medico(string nombre, string nacion, int sueldo, int experiencia) : base(nombre, nacion, sueldo)
        {
            Experiencia = experiencia;
            Nombre = nombre;
            Nacion = nacion;
            Sueldo = sueldo;
        }

        public override void Verinformacion()
        {
            Console.WriteLine("Nombre Medico:");
            Console.WriteLine(Nombre);
            Console.WriteLine("Nacion Medico:");
            Console.WriteLine(Nacion);
        }
    }
}
