using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Compra
    {
        public Compra(int id)
        {
            Id = id;
            Lineas = new List<LineaCompra>();
        }
        public int Id { get; set; }

        public List<LineaCompra> Lineas { get; set; }

        public void AddLinea (LineaCompra linea)
        {
            this.Lineas.Add(linea);
        }
        public double Importe
        {
            get
            {
                double total = 0;
                foreach(LineaCompra linea in Lineas)
                { 
                    total += linea.Importe;
                }
                return total;
            }

        }

        public double ImporteConIVA()
        {
                double total = 0;
                foreach (LineaCompra linea in Lineas)
                {
                    total += linea.ImporteConIVA();
                }
                return total;

        }
    }
}
