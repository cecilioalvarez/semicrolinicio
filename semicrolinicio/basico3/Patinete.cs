using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Patinete : IConducibleConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("el patinete arranca");
        }

        public void Avanzar()
        {
            Console.WriteLine("el patinete avanza");
        }

        public void Conectar()
        {
            Console.WriteLine("conecto el patinete");
        }

        public void Desconectar()
        {
            Console.WriteLine("desconecto el patinete");
        }

        public void Girar()
        {
            Console.WriteLine("el patinete gira");
        }

        public void Parar()
        {
            Console.WriteLine("el patinete Para");
        }
    }
}
