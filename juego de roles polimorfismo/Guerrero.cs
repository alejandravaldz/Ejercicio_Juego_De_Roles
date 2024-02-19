using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_de_roles_polimorfismo
{
    internal class Guerrero: Personaje
    {
        public string Armadura { get; set; }
        public string Escudo { get; set; }
        public string Arma { get; set; }

        public void Atacar()
        {
            Console.WriteLine($"!{Nombre} ataca con su "+ Arma);
        }

        public void Protegerlaspersonas()
        {
            Console.WriteLine($"!{Nombre} protege a las personas con su" + Armadura!);
                
                }
    }
}
