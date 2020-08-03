using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa8
    {
        static void Main(string[] args)
        {
            // operador new construye un objeto en memoria

            Factura f = new Factura(5,"ordenador",500);
            //f.Numero = 5;
            //f.Concepto = "ordenador";
            //f.Importe = 400;

            Factura f2 = new Factura
            {
                Numero = 5,
                Concepto = "otro",
                Importe = 100

            };
            Console.WriteLine(f.CalcularIVA());
            Console.WriteLine(f.CalcularIVA(10));
            Console.ReadLine();




        }
        // bloque de codigo reutilizable

    }
}
