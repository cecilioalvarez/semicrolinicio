using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class HistorialMedico
    {

        public int Numero { get; set; }
        public DateTime fecha { get; set; }
        public HistorialMedico(int numero, DateTime fecha)
        {
            Numero = numero;
            this.fecha = fecha;
        }

    }
}
