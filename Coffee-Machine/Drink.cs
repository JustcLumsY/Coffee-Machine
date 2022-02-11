using System;
using System.Linq;

namespace Coffee_Machine
{
    internal class Drink
    {
        public string Name { get; }
        public int Id { get; }
        public Recipe Recipe { get; set; }

        public Drink(int id, string name,  Recipe recipe)
        {
            Id = id;
            Name = name;
            Recipe = recipe;


        
        }
           


      
    }
}
