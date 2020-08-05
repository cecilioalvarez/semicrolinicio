using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio
{
   abstract class Animal
    {
        public bool estaVacunado { get; set; }


        public Animal(string color, int peso)
        {
            Color = color;
            Peso = peso;
        }

        public string Color { get; set; }
        public int Peso { get; set; }

        public abstract void Vacunar();

        public override bool Equals(object obj)
        {
            return obj is Animal animal &&
                   Color == animal.Color &&
                   Peso == animal.Peso;
        }

        public override int GetHashCode()
        {
            int hashCode = -230270368;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Color);
            hashCode = hashCode * -1521134295 + Peso.GetHashCode();
            return hashCode;
        }
    }
}
