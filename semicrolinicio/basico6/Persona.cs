using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Persona
    {
        public string Nombre { get; set; }
        private int _edad;
        public int Edad
        {

            get
            {
                return _edad;
            }
            set
            {
                if (value<0 || value>120)
                {
                    throw new Exception("la edad no es valida");
                }else
                {
                    _edad = value;
                }
            }

        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
