using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Electrodomestico
    {
        public int NumeroSerie { get; set; }
        public virtual void Encender()
        {
            Console.WriteLine("el electrodomestico se enciende");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("el electrodomestico se apaga");
        }

    }
}
