using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico4
{
    class Bombilla : IEncendible
    {
        public void Apagar()
        {
            Console.WriteLine("la bombilla se apaga");
        }

        public void Encender()
        {
            Console.WriteLine("la bombilla se enciende");
        }
    }
}
