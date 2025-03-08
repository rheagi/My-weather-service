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

        public Cup MakeCoffee(string choice)
        {
            Cup drink;

            switch (choice)
            {
                case "espresso":
                    drink = MakeEspresso();
                    break;
                case "americano":
                    drink = MakeAmericano();
                    break;
                case "cappuccino":
                    drink = MakeCappuccino();
                    break;
                case "latte":
                    drink = MakeLatte();
                    break;
                case "mocha":
                    drink = MakeMocha();
                    break;
                default:
                    Console.Write("\nMistake! Try again: ");
                    return null;
            }

            Console.WriteLine($"\nYour {choice} is ready. Enjoy!");
            return drink;

        }


        private Cup MakeEspresso()
        {
            Cup espressoCup = SetCup();
            AddCoffee(espressoCup);
            return espressoCup;
        }

        private Cup MakeAmericano()
        {
            Cup americanoCup = SetCup();
            AddCoffee(americanoCup);
            AddWater(americanoCup);
            return americanoCup;
        }

        private Cup MakeCappuccino()
        {
            Cup cappuccinoCup = SetCup();
            AddCoffee(cappuccinoCup);
            AddMilk(cappuccinoCup);
            return cappuccinoCup;
        }

        private Cup MakeLatte()
        {
            Cup latteCup = SetCup();
            AddCoffee(latteCup);
            AddMilk(latteCup);
            AddMilk(latteCup);
            return latteCup;
        }

        private Cup MakeMocha()
        {
            Cup mochaCup = SetCup();
            AddCoffee(mochaCup);
            AddMilk(mochaCup);
            AddChocolate(mochaCup);
            return mochaCup;
        }

        private Cup SetCup()
        {
            return new Cup();
        }

        private void AddCoffee(Cup cup)
        {
            Console.WriteLine("Adding coffee...");
            cup.Content.Add("coffee");
        }

        private void AddMilk(Cup cup)
        {
            Console.WriteLine("Adding milk...");
            cup.Content.Add("milk");
        }

        private void AddWater(Cup cup)
        {
            Console.WriteLine("Adding water...");
            cup.Content.Add("water");
        }

        private void AddChocolate(Cup cup)
        {
            Console.WriteLine("Adding chocolate...");
            cup.Content.Add("chocolate");
        }
    }
}
