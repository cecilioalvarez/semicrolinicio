
using semicrolinicio.basico2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa17
    {
        static void Main(string[] args)
        {
            Animal g1 = FactoriaAnimales.GetAnimal("Gato", 30, "blanco");
            Animal p1 = FactoriaAnimales.GetAnimal("Perro", 30, "blanco");

            Perro p2 = new Perro("negro",20);
            Perro p3 = new Perro("negro", 20);
            Console.WriteLine(p2.Equals(p3));

            //Console.WriteLine(p1.GetType().Name);
        
            VacunarAnimal(g1);
            VacunarAnimal(p1);
            Console.ReadLine();
        }

        public static  void VacunarAnimal(Animal a)
        {
           
            a.Vacunar();
            //Console.WriteLine(a.estaVacunado);

        }

    }
}
