using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semicrolinicio.basico5
{
    class Pack<T,K>
    {
        public T Elemento1 { get; set; }
        public K Elemento2 { get; set; }

        public Pack(T elemento1, K elemento2)
        {
            Elemento1 = elemento1;
            Elemento2 = elemento2;
        }

    }
}
