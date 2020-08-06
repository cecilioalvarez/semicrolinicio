using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico4
{
    class EnchufeSmartAdaptador : IEncendibleVoz
    {
        public string Id { get ; set ; }
        public IEncendible Encendible;

        public EnchufeSmartAdaptador(string id, IEncendible encendible)
        {
            Id = id;
            Encendible = encendible;
        }

        public void Apagar()
        {
            Encendible.Apagar();
        }

        public void ApagarConVoz()
        {
            Encendible.Apagar();
        }

        public void Encender()
        {
            Encendible.Encender();
        }

        public void EncenderConVoz()
        {
            Encendible.Encender();
        }
    }
}
