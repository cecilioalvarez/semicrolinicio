using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico4
{
    interface IEncendibleVoz:IEncendible
    {
        string Id { get; set; }
        void EncenderConVoz();
        void ApagarConVoz();
    }
}
