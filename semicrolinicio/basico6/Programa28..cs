
using ES.Semicrol.Fundanet;
using semicrolinicio.basico2;
using semicrolinicio.basico4;
using semicrolinicio.basico5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Programa28
    {
        //era necesario declarar una funcion especial
        // recibe 2 parametros T1,T2 y devuelve T3
        //public delegate int Operacion(int a, int b);


        static void Main(string[] args)
        {
            Func<int, int, int> mifuncion = (a, b) => a * b; 


       
            OperarPorPantalla(2, 3,Sumar);
            OperarPorPantalla(2, 3, Restar);
            OperarPorPantalla(2, 2, mifuncion);
            OperarPorPantalla(2,4,(a,b)=>a/b);
            Console.ReadLine();
          
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        public static int Restar(int a,int b)
        {
            return a - b;
        }

        public static void OperarPorPantalla(int a , int b,
            Func<int,int,int> tipoOperación)
        {
            Console.WriteLine("*********");
            Console.WriteLine(tipoOperación(a, b));
            Console.WriteLine("************");
           
        }

        public static void RestarPorPantalla(int a, int b)
        {
            Console.WriteLine("*********");
            Console.WriteLine(a - b);
            Console.WriteLine("************");

        }


    }
}
