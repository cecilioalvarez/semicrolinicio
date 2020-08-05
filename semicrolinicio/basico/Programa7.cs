using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa7
    {
        static void Main(string[] args)
        {
            // operador new construye un objeto en memoria

            Persona p1 = new Persona();
            p1.Nombre = "pedro";
            p1.Apellidos = "alvarez";
            p1.Edad = 20;
            Console.WriteLine(p1.Nombre);
            Console.WriteLine(p1.Apellidos);
            Console.WriteLine(p1.Edad);
            Console.WriteLine(p1.TiempoParaJubilarse());
            Console.ReadLine();



        }
        // bloque de codigo reutilizable

    }
}
