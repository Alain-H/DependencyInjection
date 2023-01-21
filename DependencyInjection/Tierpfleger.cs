using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Tierpfleger
    {
        Hund hund = null;
        public Tierpfleger(Hund h)
        {
            hund = h;
        }

        public Hund getHund()
        {
            return hund;
        }

        public void setHund(Hund h)
        {
            hund = h;          
        }
    }
}
