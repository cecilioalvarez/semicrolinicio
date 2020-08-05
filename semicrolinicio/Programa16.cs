using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa16
    {
        static void Main(string[] args)
        {

            Ordenador o = new Ordenador(new CPU(),new Monitor(15));
            
            o.Encender();
            Portatil p = new Portatil(new CPU());
           
            p.Encender();
            Console.ReadLine();




        }


    }
}
