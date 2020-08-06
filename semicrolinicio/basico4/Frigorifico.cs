using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico4
{
    class Frigorifico : IEncendible
    {
        public void Apagar()
        {
            Console.WriteLine("el frigorifico se apaga");
        }

        public void Encender()
        {
            Console.WriteLine("el frigorifico se Enciende");
        }
    }
}
