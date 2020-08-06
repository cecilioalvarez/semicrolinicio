
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
    class Programa22
    {
        static void Main(string[] args)
        {

            Cocina c = new Cocina();
            c.AddEncendible(new Bombilla());
            c.AddEncendible(new Bombilla());
            c.AddEncendible(new BombillaSmart("1"));
            //c.AddEncendible(new Frigorifico());
            c.AddEncendible(new EnchufeSmartAdaptador("2", new Frigorifico(20)));
            //c.EncenderTodo();
            c.EncenderPorVoz("2");
            Console.ReadLine();
           

        }

        
    }
}
