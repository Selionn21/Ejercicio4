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
            vida = 90;
            maldad = 30;
        }

        public override void MostrarEstadisticas()
        {
            Console.WriteLine("Vida: " + vida + " Maldad: " + maldad);
        }
    }
}
