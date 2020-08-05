using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico2
{
    class FactoriaAnimales
    {

        public static Animal GetAnimal(string tipo,int peso,string color)
        {
            if (tipo.Equals("Gato"))
            {
                return new Gato(color, peso);
            }else
            {
                return new Perro(color, peso);
            }

        }
    }
}
