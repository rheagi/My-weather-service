using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson.Recipes
{
    internal class CappuccinoRecipe : CoffeeRecipe
    {
        public override void MakeCoffee(Cup cup)
        {
            AddCoffee(cup);
            AddMilk(cup);
        }
    }
}
