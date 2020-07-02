using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Entrenador : Persona
    {
        int Tactica;
        
        public Entrenador(string nombre, string nacion, int sueldo, int tactica) : base(nombre, nacion, sueldo)
        {
            Tactica = tactica;
        }
        public void cambiar_jugador()
        {

        }
    }
}
