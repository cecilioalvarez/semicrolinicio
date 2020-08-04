using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa11
    {
        static void Main(string[] args)
        {

            List<Nota> misNotas = new List<Nota>();

            misNotas.Add(new Nota(3));
            misNotas.Add(new Nota(4));
            misNotas.Add(new Nota(5));
            misNotas.Add(new Nota(6));
            misNotas.Add(new Nota(7));
            misNotas.Add(new Nota(8));
            /*
            foreach (Nota n in misNotas)
            {
                Console.WriteLine(n.Valor);

            }
            */
            Nota notaMayor = new Nota(0);


            foreach (Nota unaNota in misNotas)
            {
                // como usar programacion oo 
                notaMayor = unaNota.ElegirMayor(notaMayor);

            }
            Console.WriteLine(notaMayor.Valor);

            double media = 0;

            foreach (Nota unaNota in misNotas)
            {
                // media+=unaNota.Valor;
                media = media + unaNota.Valor;

            }
            Console.WriteLine(media / misNotas.Count);



            Console.ReadLine();




        }


    }
}
