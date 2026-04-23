using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio4
{
    internal class Villano : Personaje
    {   
        public Villano()
        {
            vida = 120;
            maldad = 40;
        }

        public override void MostrarEstadisticas()
        {
            Console.WriteLine("Vida: " + vida + " Maldad: " + maldad);
        }
    }
}
