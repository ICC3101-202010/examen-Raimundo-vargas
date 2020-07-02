using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Medico : Persona
    {
        
        string Experiencia;

        public Medico(string nombre, string nacion, int sueldo, string experiencia) : base(nombre, nacion, sueldo)
        {
            Experiencia = experiencia;
        }

        public void Evaluar()
        {

        }
        public void Curar()
        {

        }
    }
}
