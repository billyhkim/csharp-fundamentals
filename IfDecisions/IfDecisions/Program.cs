using System;

namespace IfDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Billy's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new dog!";
            else
            {
                message = "Sorry, not a choice! ";
                message += "You Lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Billy's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            // Ternary work like JS
            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}, {1}.", message, "Billy");
            Console.ReadLine();
        }
    }
}
