
using ES.Semicrol.Fundanet;
using semicrolinicio.basico2;
using semicrolinicio.basico4;
using semicrolinicio.basico5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Programa26
    {
        static void Main(string[] args)
        {

            try
            {
                Persona p = new Persona("pedro", 1000);
                Console.WriteLine(p.Edad);
            }
            catch (Exception e )
            {

                Console.WriteLine(e);
            }
            Console.ReadLine(); 
        }

        
    }
}
