using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c, d;

            c = a++ + b++;
            d = ++a + ++b;

            Console.WriteLine($"a = {a} | b = {b} \nSuffix sum = {c} | Prefix sum = {d}");

            System.Console.WriteLine("_________________________________________________");

            int e = 4, f = 5, g, h;

            g = e-- - f--;
            h = --e - --f;

            Console.WriteLine($"e = {e} | f = {f} \nSuffix subtr = {g} | Prefix subtr = {h}");
        }
    }
}
