using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_de_roles_polimorfismo
{
    internal class Personaje
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }

        public void Presentarse()
        {
            Console.WriteLine($"Soy {Nombre}, mi nivel es {Nivel}.");
        }
    }
}
