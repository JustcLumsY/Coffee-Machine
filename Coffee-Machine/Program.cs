using System;
using System.Linq;

namespace Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var drinks = new[]
            {
                new Drink(1, "Espresso", new Recipe(1,"Espresso", new Espresso(3), new Milk(2), new Sugar(1))),
                new Drink(2, "Black with Sugar", new Recipe(2,"Black with Sugar",new Americano(3), new Sugar(2)))
            };

            var customers = new[]
            {
                new Customer("John", drinks.Single(x => x.Id == 1)),
                new Customer("Sam", drinks.Single(x => x.Id == 2)),
            };

          



        }
    }
          

        
    
}
