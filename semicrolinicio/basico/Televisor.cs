using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Televisor:Electrodomestico
    {
        public int pulgadas { get; set; }

        public override void Encender()
        {
            Console.WriteLine("el televisor se enciende");
        }
        public override void Apagar()
        {
            Console.WriteLine("el televisor se apaga");
        }
    }
}
