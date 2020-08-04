using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Paciente
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }

        public HistorialMedico Historial { get; set; }

        public Paciente(string dNI, string nombre,
            HistorialMedico historial):this(dNI,nombre)
        {
           // no inicializo los campos porque 
           // delego en el constructor de dos parametros
            Historial = historial;
        }

        public Paciente(string dNI, string nombre)
        {
            DNI = dNI;
            Nombre = nombre;
        }
    }
}
