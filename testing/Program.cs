using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool loop = false;

            while (loop == false)
            {
                Console.Write("Insert a number: ");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out a);

            if (result == true)
            {
                int i = int.Parse(input);
                System.Console.WriteLine($"Your number is {i}");
                break;
            }
            else
            {
                System.Console.WriteLine($"{input} is not a number!");
                System.Console.WriteLine("_________________________");
            }
            }

            
        }
    }
}
