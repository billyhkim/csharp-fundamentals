using System;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Found 7!");
                    break;
                }
            }


            Console.ReadLine();
        }
    }
}
