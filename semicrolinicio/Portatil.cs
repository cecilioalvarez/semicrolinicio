using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Portatil : Ordenador
    {
        public Portatil(CPU CPU): base(CPU, new Monitor(15))
        {

           
        }

        public override void Encender()
        {
            Console.WriteLine("el portatil se enciende despacio");
            base.EncenderMonitor();
            base.EncenderCPU();
            Console.WriteLine("el portatil termino de encender");
        }
    }
}
