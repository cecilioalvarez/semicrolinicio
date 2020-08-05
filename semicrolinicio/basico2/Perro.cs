
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Perro : Animal
    {
        public string Collar { get; set; }
        public Perro(string color, int peso) : base(color, peso)
        {
        }
        public override void  Vacunar()
        {
            Console.WriteLine("vacunamos al perro con 2 inyecciones");
            estaVacunado = true;

        }
    }
}
