using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson.Recipes
{
    public abstract class CoffeeRecipe
    {
        protected void AddCoffee(Cup cup)
        {
            Console.WriteLine("Adding coffee...");
            cup.Content.Add("coffee");
        }

        protected void AddMilk(Cup cup)
        {
            Console.WriteLine("Adding milk...");
            cup.Content.Add("milk");
        }

        protected void AddWater(Cup cup)
        {
            Console.WriteLine("Adding water...");
            cup.Content.Add("water");
        }

        protected void AddChocolate(Cup cup)
        {
            Console.WriteLine("Adding chocolate...");
            cup.Content.Add("chocolate");
        }

        public abstract void MakeCoffee(Cup cup);
    }
}
