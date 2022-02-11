using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
     class Recipe : IEnumerable<Ingredient>
     {
         int Id { get; }
         string Name { get; }
         private readonly IEnumerable<Ingredient> _ingredients;

         public Recipe(int id, string name, params Ingredient[] ingredients)
         {
            Id = id;
            Name = name;
            _ingredients = ingredients;
         }

         public IEnumerator<Ingredient> GetEnumerator() => _ingredients.GetEnumerator();
         IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       
    }
}
