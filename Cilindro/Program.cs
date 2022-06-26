using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Welcome to CylindR!  ");
            System.Console.WriteLine("**___________________**\n");


            // System.Console.Write("Insert the cylinder's radius: ");
            double x = 0;
            bool loop1 = false;

            double y = 0;
            bool loop2 = false;

            double a = 0, r = 0, v, s;

            

            while (loop1 == false)
            {
                System.Console.Write("Insert the cylinder's height: ");
                string input1 = Console.ReadLine();
                bool result1 = double.TryParse(input1, out x);

                if (result1 == true)
                {
                    a = double.Parse(input1);
                    break;
                }
                else
                {
                    System.Console.WriteLine($"{input1} is not a number!");
                    System.Console.WriteLine("_________________________\n");
                }
            }
            while (loop2 == false)
            {
                System.Console.Write("Insert the cylinder's radius: ");
                string input2 = Console.ReadLine();
                bool result2 = double.TryParse(input2, out y);

                if (result2 == true)
                {
                    r = double.Parse(input2);
                    break;
                }
                else
                {
                    System.Console.WriteLine($"{input2} is not a number!");
                    System.Console.WriteLine("_________________________\n");
                }
            }
            v = Math.PI * (r*r) * a;
            s = 2 * Math.PI * r * (r + a);

            System.Console.WriteLine($"\nThe cylinder's volume is {v:f2}");
            System.Console.WriteLine($"The cylinder's surface area is {s:f2}\n");
            System.Console.WriteLine("Thanks for using Cylindr!");

        }
    }
}
