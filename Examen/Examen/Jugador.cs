using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Jugador : Persona
    {
        int Ataque;
        int Defensa;
        int Camiseta;
        public Jugador(string nombre, string nacion, int sueldo, int ataque, int defensa, int camiseta) : base(nombre, nacion, sueldo)
        {
            Ataque = ataque;
            Defensa = defensa;
            Camiseta = camiseta;
        }
        
    }
}
