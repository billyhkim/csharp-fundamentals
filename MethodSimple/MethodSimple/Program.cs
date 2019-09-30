using System;

namespace MethodSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bill's Name Game!");

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string city = Console.ReadLine();
            string message = Console.ReadLine();

            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);
            string reversedMessage = ReverseString(message);

            DisplayResult(reversedFirstName, reversedLastName, reversedCity);
            DisplayResult(reversedMessage);
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write(message);
        }
    }
}
