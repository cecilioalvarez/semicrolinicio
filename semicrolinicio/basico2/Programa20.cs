
using ES.Semicrol.Fundanet;
using semicrolinicio.basico2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa20
    {
        static void Main(string[] args)
        {

            Dictionary<string, Persona> diccionario
                = new Dictionary<string, Persona>();
            Persona p1 = new Persona();
            p1.Nombre = "pedro";
            p1.Apellidos = "gomez";
            p1.Edad = 50;

            Persona p2 = new Persona();
            p2.Nombre = "ana";
            p2.Apellidos = "perez";
            p2.Edad = 30;

            diccionario.Add(p1.Nombre, p1);
            diccionario.Add(p2.Nombre, p2);


            //Console.WriteLine(diccionario["pedro"].Apellidos);

            foreach (Persona p in diccionario.Values)
            {

                Console.WriteLine(p);
            }

            foreach (String nombre in diccionario.Keys)
            {

                Console.WriteLine(nombre);
            }


            Telefono t = new Telefono();
            t.Numero = 123456789;
            Console.WriteLine(t.Numero);
            Console.ReadLine();




        }
    }
}
