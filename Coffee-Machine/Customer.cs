using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    internal class Customer
    {
        public string Name { get; }
        public Drink Drink { get; }

        public Customer(string name, Drink drink)
        {
            Name = name;
            Drink = drink;

        
        }


    }
}
