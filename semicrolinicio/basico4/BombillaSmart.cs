using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico4
{
    class BombillaSmart:Bombilla,IEncendibleVoz
    {
        public string Id { get; set; }

        public BombillaSmart(string id)
        {
            Id = id;
        }

        public void ApagarConVoz()
        {
            Console.WriteLine("Apagada por Voz");
        }

        public void EncenderConVoz()
        {
            Console.WriteLine("Encendida por Voz");
        }

        public override bool Equals(object obj)
        {
            return obj is BombillaSmart smart &&
                   Id == smart.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
