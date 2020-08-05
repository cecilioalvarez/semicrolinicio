﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Madalena
    {
        private string _color;
        private  int _peso;
        private  int _precio;
        
        public string Color
        {
            get
            {

                return _color;
            }
            set
            {
                if (!value.Equals("azul"))
                {
                    _color = value;

                }
              
            }


        }
        public int Peso
        {
            get
            {

                return _peso;
            }
            set
            {
                if (_peso<4)
                {
                    _peso = value;

                }

            }


        }
        public int Precio
        {
            get
            {

                return _precio;
            }
            set
            {
                if (_precio < 4)
                {
                    _precio = value;

                }

            }


        }
    }
}