using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_de_roles_polimorfismo
{
    internal class Mago : Personaje
    {
        public int PuntosMagia { get; set; }
       
        public void LanzarHechizo()
        {
            Console.WriteLine($"¡{Nombre} lanza un hechizo poderoso! ");
            Console.WriteLine();

            Console.WriteLine($"Puntos de magia: {PuntosMagia}");
        } 
    
        public int PuntosTransformación { get; set; }

        public void Transformarce()
        {
            Console.WriteLine($"¡{Nombre} puede transformarce en diferentes personajes! ");

            Console.WriteLine($"Estos son sus puntos de Transformación: {PuntosTransformación}");
        }

        

    }
}

