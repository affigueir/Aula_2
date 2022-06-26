using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Console.Write("Insert a number: ");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out a);

            if (result == true)
            {
                int i = int.Parse(input);
                System.Console.WriteLine($"Your number is {i}");
            }
            else
            {
                System.Console.WriteLine("That is not a number!");
            }

            
        }
    }
}
