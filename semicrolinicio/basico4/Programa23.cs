
using ES.Semicrol.Fundanet;
using semicrolinicio.basico2;
using semicrolinicio.basico4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Programa23
    {
        static void Main(string[] args)
        {

            List<Frigorifico> lista = new List<Frigorifico>();
            lista.Add(new Frigorifico(20));
            lista.Add(new Frigorifico(20));
            lista.Add(new Frigorifico(30));
            lista.Add(new Frigorifico(60));
            lista.Add(new Frigorifico(10));
            lista.Sort(new ComparadorPotencia());

            foreach(Frigorifico f in lista)
            {
                Console.WriteLine(f.Potencia);
            }

            Console.ReadLine();



        }

        
    }
}
