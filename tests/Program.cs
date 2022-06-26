using System;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int i1 = 3;
            int i2 = 1;
            int i3 = -8;
            int x = 2; */

            //Put instruction
            Console.WriteLine("Insert a number");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            string bin = Convert.ToString(num, 2);
            
            int binReal = 0b11111111111111111111111111111000;
;

            Console.WriteLine($"Your number in binary is:\n{bin}");
            Console.WriteLine(binReal);
        }
    }
}

