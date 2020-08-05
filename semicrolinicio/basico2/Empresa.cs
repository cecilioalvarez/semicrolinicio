using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico2
{
    class Empresa
    {
        public List<Alquiler> Alquileres { get; set; }
        public Empresa()
        {
            Alquileres = new List<Alquiler>();
        }

        public void AddAlquiler(Alquiler a)
        {
            this.Alquileres.Add(a);
        }

        public double ImpresosTotales()
        {
            double total = 0;
            foreach(Alquiler a in Alquileres)
            {
                total += a.ImporteFinal();
            }
            return total;
        }
    }
}
