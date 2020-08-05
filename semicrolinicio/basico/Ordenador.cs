using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Ordenador
    {
        public Ordenador(CPU cPU, Monitor monitor)
        {
            CPU = cPU;
            Monitor = monitor;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public CPU CPU { get; set; }

        public Monitor Monitor { get; set; }
        public virtual void Encender()
        {
            //Console.WriteLine("el ordenador se enciende");
            EncenderCPU();
            EncenderMonitor();
          
        }

        protected virtual void EncenderCPU()
        {
            CPU.Encender();
        }

         protected virtual void EncenderMonitor()
        {
            Monitor.Encender();
        }
        public void Apagar ()
        {
           Console.WriteLine("el ordenador se apaga");
        }
    }
}
