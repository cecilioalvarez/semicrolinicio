using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Rectangulo
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        //recibe el constructor dos parametros
        //asigname los valores a las propiedades
        //publicas

        public Rectangulo(int lado1, int lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public static double Area(int lado1, int lado2)
        {
            return lado1 * lado2;
        }
        public double Area()
        {
            return Rectangulo.Area(this.Lado1, this.Lado2);

        }
        public double Perimetro()
        {
            return 2 * Lado1 + 2 * Lado2;

        }
    }
}
