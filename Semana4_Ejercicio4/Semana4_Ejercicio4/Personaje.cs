using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio4
{
    internal class Personaje
    {

        public int vida { get; set; }
        public int valentia { get; set; }
        public int maldad { get; set; }

        public Personaje()
        {
            this.vida = vida;
            this.valentia = valentia;
            this.maldad = maldad;
        }

        public void DañoRecibido(int daño)
        {
            vida -= daño;
            Console.WriteLine("Recibes " + daño + " de daño");
        }

        public void GanarVida(int curacion)
        {
            vida += curacion;
            Console.WriteLine("Te curas " + curacion + " de vida");
        }

        public void ConseguirValentia(int mejora)
        {
            valentia += mejora;
            Console.WriteLine("Obtienes " + mejora + " de fuerza adicional");
        }

        public void PerderValentia(int debuff)
        {
            valentia -= debuff;
            Console.WriteLine("Obtienes " + debuff + " de fuerza adicional");
        }

        public void ObtenerMaldad(int mejora)
        {
            maldad += mejora;
            Console.WriteLine("Consigues " + mejora + " de maldad adicional");
        }

        public void PerderMaldad(int mejora)
        {
            maldad -= mejora;
            Console.WriteLine("Consigues " + mejora + " de maldad adicional");
        }


        public bool EstaVivo()
        {
            return vida > 0;
        }

        public bool BuenDesempeño()
        {
            return valentia > 0;
            
        }


        public virtual void MostrarEstadisticas()
        {
            Console.WriteLine("Vida: " + vida + " Fuerza: " + valentia);
        }

    




    }
}
