﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Programa12
    {
        static void Main(string[] args)
        {

            Alumno alumno1 = new Alumno("pedro");
            alumno1.AddNota(new Nota(7));
            alumno1.AddNota(new Nota(10));

            Console.ReadLine();




        }


    }
}
