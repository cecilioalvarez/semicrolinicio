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

        public void RemoveAlquiler(Alquiler a)
        {

            this.Alquileres.Remove(a);
        }
        public bool ContieneAlquiler(Alquiler a)
        {
            return this.Alquileres.Contains(a);

        }
        public int NumeroAlquileres()
        {
           return this.Alquileres.Count();
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

        public Alquiler AlquilerMasCaro()
        {

            Alquiler mayor = Alquileres[0];
            foreach (Alquiler a in Alquileres)
            {

                if (mayor.ImporteFinal()< a.ImporteFinal())
                {
                    mayor = a;
                }
                
            }
            return mayor;
        }
    }
}
