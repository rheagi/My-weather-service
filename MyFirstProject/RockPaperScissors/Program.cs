namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option1 = "ROCK";
            string option2 = "PAPER";
            string option3 = "SCISSORS";

            Console.WriteLine("Hello! This is ROCK PAPER SCISSORS game.");
            Console.Write("Player 1, type your choice: ");
            string choice1 = Console.ReadLine().ToUpper();
            Console.Write("Player 2, type your choice: ");
            string choice2 = Console.ReadLine().ToUpper();

            if (choice1 == choice2)
            {
                Console.WriteLine("It's a draw!");
            }

            else if ((choice1 == option1 && choice2 == option3) || (choice1 == option3 && choice2 == option2) || (choice1 == option2 && choice2 == option1))
            {
                Console.WriteLine("Player 1 winned!");
            }

            else if ((choice2 == option1 && choice1 == option3) || (choice2 == option3 && choice1 == option2) || (choice2 == option2 && choice1 == option1))
            {
                Console.WriteLine("Player 2 winned!");
            }

            else
            {
                Console.WriteLine("Incorrect option :(");
            }

        }
    }
}
