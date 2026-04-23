using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio4
{
    internal class Partida
    {

        public Personaje personaje;
        public string tipoPersonaje;
        public int rolElegido = 0;

        public void MenuSeleccionPersonaje()
        {
            while (true)
            {
                Console.WriteLine("Selecciona el papel a interpretar: ");
                Console.WriteLine("1. Héroe ");
                Console.WriteLine("2. Villano");

                rolElegido = int.Parse(Console.ReadLine());

                switch (rolElegido)
                {
                    case 1:
                        personaje = new Heroe();
                        tipoPersonaje = "Héroe";
                        Console.WriteLine("Has elegido tomar el papel del Héroe");
                        PrimeraEscenaHeroe();
                        return;

                    case 2:
                        personaje = new Villano();
                        tipoPersonaje = "Villano";
                        Console.WriteLine("Has elegido tomar el papel del villano");
                        PrimeraEscenaVillano();
                        return;

                    default:
                        Console.WriteLine("Selección incorrecta, intenta otra vez");
                        break;
                }

            }
        }

        public void PrimeraEscenaHeroe()
        {
        
             Console.WriteLine("Escuchas ruidos provenientes de la ciudad.... ves humo y explosiones");
             personaje.MostrarEstadisticas();

             Console.WriteLine("1. Ir a investigar el atentado (Gana Valentía)");
             Console.WriteLine("2. Hacer caso omiso y quedarse viendo la televisión (Pierde valentía) ");

             int seleccion = int.Parse(Console.ReadLine());


            switch (seleccion)
            {
                case 1: personaje.ConseguirValentia(10); break;

                case 2: personaje.PerderValentia(20); break;
            }

            VerificarEstadoHeroe();
            SegundaEscenaHeroe();
            
        }

        public void SegundaEscenaHeroe()
        {
            Console.WriteLine("De pronto el villano arremete contra ti con un golpe explosivo e inicia una batalla en tu contra");
            personaje.MostrarEstadisticas();

            Console.WriteLine("1. Luchar contra el villano, proteger la ciudad y saldar las cuentas pendientes (Gana valentía)");
            Console.WriteLine("2. Escapar del villano y dejar la ciudad en sus manos. (Pierde valentía y vida)");

            int seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1: personaje.ConseguirValentia(30); break;

                case 2: personaje.PerderValentia(20); break;
            }

            VerificarEstadoHeroe();
            TerceraEscenaHeroe();

        }

        public void TerceraEscenaHeroe()
        {
            Console.WriteLine("(Si decidiste antes huir, tomar esto como resultado de otro combate futuro)... Derrotas al enemigo y ahora tienes que tomar una decisión.... " +
                "Capturarlo y encerrarlo, evitando su muerte a pesar de todas las víctimas que asesino; o matarlo y eliminar la amenaza de una vez por todas");
            personaje.MostrarEstadisticas();

            Console.WriteLine("1. Intentar Capturarlo (Pierde -30 valentía y -50 vida)");
            Console.WriteLine("2. Asesinar al enemigo (Gana +20 valentía)");

            int seleccion = int.Parse (Console.ReadLine());
           
            switch (seleccion)
            {
                case 1: personaje.PerderValentia(30); personaje.DañoRecibido(50);  break;

                case 2: personaje.ConseguirValentia(20); break;
            }

            VerificarEstadoHeroe();

            if (personaje.valentia > 60)
            {
                Console.WriteLine("Eres el mejor de los héroes");
            }
            else if (personaje.valentia < 60 && personaje.valentia > 0)
            {
                Console.WriteLine("Matas al villano y salvas la ciudad, la ciudad está en paz, por ahora......");
            }
            else
            {
                Console.WriteLine("Eres una decepción como heroe");
            }

            
            
        }



       public void PrimeraEscenaVillano()
        {
            Console.WriteLine("El día del juicio ha llegado, el día que la ciudad será tuya y gobernarás sobre todos");
            personaje.MostrarEstadisticas();

            Console.WriteLine("1. Arremeter  de forma explosiva contra la ciudad, causando estragos y muerte (+20 maldad ");
            Console.WriteLine("2. Atacar sigilosamente puntos estratégicos de la ciudad para no ser visto (No ganas nada, solo aura)");

            int seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1: personaje.ObtenerMaldad(20); break;

                case 2: personaje.GanarVida(0); break;
            }

            VerificarEstadoVillano();
            SegundaEscenaVillano();

        }

        public void SegundaEscenaVillano()
        {
            Console.WriteLine("Aparecen las fuerzas armadas y arremeten contra ti con sus armas a distancia y espadas");
            personaje.MostrarEstadisticas();

            Console.WriteLine("1. Esquivas la arremetida y asesinas a todo el equipo de fuerzas armadas pero recibes daño no letal que te incapacita un momento (Ganas +20 maldad, pero pierdes -30 vida)");
            Console.WriteLine("2. Huyes de la zona para esconderte y preparar tu próxima emboscada (-25 maldad)");


            int seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1: personaje.ObtenerMaldad(20); personaje.DañoRecibido(30); break;

                case 2: personaje.PerderMaldad(25); break;
            }

            VerificarEstadoVillano();
            TerceraEscenaVillano();
        }

        public void TerceraEscenaVillano()
        {
            Console.WriteLine("Aparece el héroe y te enfrenta, te ves rodeado de muchos enemigos así que tomas una decisión....");
            personaje.MostrarEstadisticas();

            Console.WriteLine("1. Seguir luchando y aniquilarlos a todos, manchandote aún más las manos con sangre (+30 maldad y -70 de vida) ");
            Console.WriteLine("2. Retirarte por ahora, son muchos para ti y aún no tienes el poder suficiente (pierdes toda tu maldad)");

            int seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1: personaje.ObtenerMaldad(30); personaje.DañoRecibido(70); break;

                case 2: personaje.PerderMaldad(personaje.maldad); break;
            }

            VerificarEstadoVillano();

            if (personaje.maldad > 60)
            {
                Console.WriteLine("Ya no existe héroe que te detenga, eres el rey del mundo y puedes corromper TODO");
            }
            else if (personaje.maldad < 60 && personaje.maldad > 0)
            {
                Console.WriteLine("Eliminaste al héroe de la faz de la tierra, pero aún no posees la maldad para dominar el mundo");
            }
            else
            {
                Console.WriteLine("Eres una decepción como villano");
            } 
            
        }


        public void VerificarEstadoHeroe()
        {
            if (!personaje.EstaVivo() || !personaje.BuenDesempeño())
            {
                Console.WriteLine("Aquí termina tu historia, suerte intentando ser un buen héroe la próxima vez");
            }
        }

        public void VerificarEstadoVillano()
        {
            if (!personaje.EstaVivo())
            {
                Console.WriteLine("Aquí termina tu historia, suerte intentando ser un buen villano la próxima vez");
            }
        }



    }
}
