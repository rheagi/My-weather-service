using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson.Recipes
{
    internal class EspressoRecipe : CoffeeRecipe
    {
        public override void MakeCoffee(Cup cup)
        {
            AddCoffee(cup);
        }
    }
}
