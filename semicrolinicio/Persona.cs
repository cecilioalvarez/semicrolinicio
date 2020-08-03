﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Persona
    {
        private string _nombre;
        private string _apellidos;
        private int _edad;


        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public int Edad {
                
            get
            {

                return _edad;
            }
            set
            {

                if (value<120)
                {
                    _edad = value;
                }else
                {
                    throw new Exception("la edad no es valida");
                }
            }
        
        }
        
        public int  TiempoParaJubilarse()
        {

            return 70 - Edad;
        }
    
    }
}
