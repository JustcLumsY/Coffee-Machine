using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    internal class Espresso : Coffee
    {
        public Espresso( int amount) : base("Espresso", amount)
        {
        }
    }
}
