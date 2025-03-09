namespace ClassesLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCoffeeMaker = new CoffeeMaker();
            myCoffeeMaker.ShowMenu();

            Cup newCup;
            do
            {
                string choice = Console.ReadLine().ToLower();
                newCup = myCoffeeMaker.ServeCoffee(choice);
            }
            while (newCup == null);
        }
    }
}

// что еще добавить: оплату, ресурсы кофемашины, сахар, взбивать молоко, после ошибки заказать еще раз