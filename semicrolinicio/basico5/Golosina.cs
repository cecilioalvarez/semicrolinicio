using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico5
{
    class Golosina:IPrecio
    {
        public Golosina(string sabor)
        {
            Sabor = sabor;
        }

        public String Sabor { get; set; }
        public double Importe { get; set;}
    }
}
