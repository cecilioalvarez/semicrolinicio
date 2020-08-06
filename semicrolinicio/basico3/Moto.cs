using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Moto : IConducible
    {
        public void Arrancar()
        {
            Console.WriteLine("la moto arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("la moto avanza");
        }

        public void Girar()
        {
            Console.WriteLine("la moto gira");
        }

        public void Parar()
        {
            Console.WriteLine("la moto arranca");
        }
    }
}
