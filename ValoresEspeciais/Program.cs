using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue, b = int.MinValue;
            uint c = uint.MaxValue, d = uint.MinValue;
            double e = double.MaxValue, f = double.MinValue;

            double positiveInfinity = double.PositiveInfinity;
            double negativeInfinity = double.NegativeInfinity;
            double not = double.NaN;


            System.Console.WriteLine($"{a}\n{b}\n{c}\n{d}\n{e}\n{f}\n"); 
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine($"{positiveInfinity}\n{negativeInfinity}\n{not}");
        }
    }
}
