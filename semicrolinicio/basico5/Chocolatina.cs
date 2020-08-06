using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico5
{
    class Chocolatina:IPrecio
    {
        public string TipoChocolate { get; set; }
        public double Importe { get; set; }

        public Chocolatina(string tipoChocolate)
        {
            TipoChocolate = tipoChocolate;
        }
    }
}
