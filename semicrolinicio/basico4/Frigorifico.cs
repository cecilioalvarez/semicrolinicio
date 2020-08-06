using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico4
{
    class Frigorifico : IEncendible,IComparable<Frigorifico> 
    {
        public int Potencia { get; set; }

        public Frigorifico(int potencia)
        {
            Potencia = potencia;
        }

        public void Apagar()
        {
            Console.WriteLine("el frigorifico se apaga");
        }

        public int CompareTo(Frigorifico otroFrigorifico)
        {
          if (otroFrigorifico.Potencia<this.Potencia)
            {
                return -1;
            }else if (otroFrigorifico.Potencia==this.Potencia)
            {

                return 0;
            }else
            {

                return 1;
            }
        }

        public void Encender()
        {
            Console.WriteLine("el frigorifico se Enciende");
        }
    }
}
