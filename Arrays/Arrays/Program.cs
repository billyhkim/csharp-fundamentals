using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            /*
            // old syntactic sugar redundant
            int[] numbers1 = new int[] { 1, 2, 3, 4 };
            // newer
            int[] numbers2 = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(numbers1[3]);
            Console.WriteLine(numbers2[3]);
            */

            //string[] names = new string[] { "Billy", "Jacob", "Cho", "Stephen" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();

            /*
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "Hello, welcome to California " +
                "and the city of Irvine.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
