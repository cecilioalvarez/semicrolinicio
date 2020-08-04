using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class CPU
    {
        public string Procesador { get; set; }
        public int RAM { get; set; }

        public void Encender()
        {
            Console.WriteLine("la CPU se enciende");
        }
        public void Apagar()
        {
            Console.WriteLine("la CPU se apaga");
        }

    }
}
