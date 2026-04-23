using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio4
{
    internal class Heroe : Personaje
    {

        public Heroe()
        {
            vida = 120;
            valentia = 30;
        }

        public override void MostrarEstadisticas()
        {
            Console.WriteLine("Vida: " + vida + " Valentia: " + valentia);
        }
    }
}
