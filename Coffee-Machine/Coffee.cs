using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    abstract class Coffee : Ingredient
    {
        protected Coffee(string name, int amount) : base(name, amount)
        {
        }
    }
}
