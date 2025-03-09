using ClassesLesson.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson
{
    internal class CoffeeMaker
    {
        public void ShowMenu()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("This is Coffee Maker.\n");
            Console.WriteLine("We have espresso, americano, cappuccino, latte and mocha.\n");
            Console.Write("Choose what you want: ");
        }

        public CoffeeRecipe SelectRecipe(string choice)
        {
            switch (choice)
            {
                case "espresso":
                    return new EspressoRecipe();
                case "americano":
                    return new AmericanoRecipe();
                case "cappuccino":
                    return new CappuccinoRecipe();
                case "latte":
                    return new LatteRecipe();
                case "mocha":
                    return new MochaRecipe();
                default:
                    Console.Write("\nMistake! Try again: ");
                    return null;
            }
        }

        public Cup ServeCoffee(string choice)
        {
            CoffeeRecipe recipe = SelectRecipe(choice);

            if (recipe == null)
                return null;

            Cup cup = SetCup();
            recipe.MakeCoffee(cup);

            Console.WriteLine($"\nYour {choice} is ready. Enjoy!");
            return cup;
        }

        private Cup SetCup()
        {
            return new Cup();
        }

        
    }
}
