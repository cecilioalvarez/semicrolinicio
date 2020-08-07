
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
    class Programa27
    {
        delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {

            Operacion o= new Operacion(Sumar);

            int resultado = o(2, 2);
            Console.WriteLine(resultado);
            Console.ReadLine(); 
        }

        public static int Sumar(int a , int b)
        {

            return a + b;
        }

        
    }
}
