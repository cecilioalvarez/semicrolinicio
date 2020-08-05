using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa9
    {
        static void Main(string[] args)
        {
           
           
            Nota nResultado=Nota.ElegirMayor(new Nota(7), new Nota(3));
            Nota n1 = new Nota(7);
            Nota n2 = new Nota(8);

            Nota nResultado2=n2.ElegirMayor(n1);
            Console.WriteLine(nResultado2.Valor);
            
            Console.ReadLine();
            
            /*
            Rectangulo.Area(2, 2);
            Rectangulo r = new Rectangulo(2, 3);
            r.Area();

            */

        }
        // bloque de codigo reutilizable

    }
}
