using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Monitor
    {
        public int Pulgadas { get; set; }

        public void Encender()
        {
            Console.WriteLine("el monitor se enciende");
        }
        public void Apagar()
        {
            Console.WriteLine("el monitor se apaga");
        }

    }
}
