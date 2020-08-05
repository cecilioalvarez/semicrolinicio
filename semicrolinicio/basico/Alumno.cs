using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
    class Alumno
    {
        public string Nombre { get; set; }
        //añadiendo notas poco a poco
        private List<Nota> _notas = new List<Nota>();

        public List<Nota> Notas
        {
            get
            {
                return _notas;
            }
            set
            {
                _notas = value;
            }
        }
        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public void AddNota (Nota nota)
        {
            this.Notas.Add(nota);
        }

        public Nota NotaMayor()
        {
            Nota notaMayor = Notas[0];
            foreach (Nota unaNota in Notas)
            {
                // como usar programacion oo 
                notaMayor = unaNota.ElegirMayor(notaMayor);

            }
            return notaMayor;
        }

        public Nota NotaMedia()
        {

            double media = 0;

            foreach (Nota unaNota in Notas)
            {
                // media+=unaNota.Valor;
                media = media + unaNota.Valor;

            }
            return  new Nota(media / Notas.Count);
        }
    }
}
