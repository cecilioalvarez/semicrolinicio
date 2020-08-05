using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa14
    {
        static void Main(string[] args)
        {

            Compra c = new Compra(1);
          
            c.AddLinea(new LineaCompra(1, "ordenador", 500));
            c.AddLinea(new LineaCompra(1, "tablet", 300));

            Console.WriteLine(c.Importe);
            Console.ReadLine();




        }


    }
}
