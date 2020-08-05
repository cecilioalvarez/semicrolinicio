using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Program2
    {
        static void Main(string[] args)
        {
            int numero = 9;
            
            if (numero>0 && numero<3)
            {

                Console.WriteLine("has sacado muy deficiente");
            }else if (numero >=3 && numero<5)
            {

                Console.WriteLine("has suspendido");
            }
            
            else if (numero>=5 && numero<7)
            {

                Console.WriteLine("has aprobado");
            }else
            {

                Console.WriteLine("buena nota");
            }

            Console.ReadLine();


        }
    }
}
