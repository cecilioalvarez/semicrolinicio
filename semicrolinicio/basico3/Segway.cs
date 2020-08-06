using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Segway : IConducible,IConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("arranco el segway");
        }

        public void Avanzar()
        {
            Console.WriteLine("Avanzar con el segway");
        }

        public void Conectar()
        {
            Console.WriteLine("conectando el segway");
        }

        public void Desconectar()
        {
            Console.WriteLine("desconectando el segway");
        }

        public void Girar()
        {
            Console.WriteLine("girar el segway");
        }

        public void Parar()
        {
            Console.WriteLine("parar el segway");
        }
    }
}
