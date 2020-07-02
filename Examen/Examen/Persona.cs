using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Persona
    {
        string nombre;
        string nacion;
        int sueldo;

        protected Persona(string nombre, string nacion, int sueldo)
        {
            this.nombre = nombre;
            this.nacion = nacion;
            this.sueldo = sueldo;
        }
    }
}
