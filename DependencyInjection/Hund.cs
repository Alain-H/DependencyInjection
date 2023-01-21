using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Hund
    {
        public string name = null;


        public Hund (string n)              //Konstruktor
        {
            name = n;
        }

        public override string ToString()
        {
            return $"Hund [name = " + name + "]";
        }

    }
}
