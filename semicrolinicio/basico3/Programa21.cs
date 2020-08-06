
using ES.Semicrol.Fundanet;
using semicrolinicio.basico2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico3
{
    class Programa21
    {
        static void Main(string[] args)
        {

            IConducible mimoto = new Moto();
            IConducibleConectable mipatinete = new Patinete();
            mipatinete.Conectar();
            mipatinete.Desconectar();
            mimoto.Avanzar();
            mipatinete.Avanzar();
            mover(mipatinete);
            Conectar(mipatinete);
            Console.ReadLine();

        }

        public static void mover(IConducible c)
        {
            c.Arrancar();
            c.Avanzar();
            c.Girar();
            c.Avanzar();
            c.Parar();

        }

        public static void Conectar(IConectable c)
        {
            c.Conectar();

        }
    }
}
