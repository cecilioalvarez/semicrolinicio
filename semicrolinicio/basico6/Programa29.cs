
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
    class Programa29
    {
        static void Main(string[] args)
        {

            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("pepe", 30));
            lista.Add(new Persona("ana", 40));
            lista.Add(new Persona("maria", 10));
            lista.Add(new Persona("andres", 50));

            IEnumerable<Persona> resultado=lista
                .Where((personita) => personita.Edad >= 40);

            foreach (Persona p in resultado)
            {
                Console.WriteLine(p.Nombre);
            }

            Console.ReadLine(); 
        }
    }
}
