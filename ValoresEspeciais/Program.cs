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

            int max = int.MaxValue;
            int overMax = max + 1;

            double megaMax = double.MaxValue;
            double ultraMax = 2 * megaMax;

            float normalMax = float.MaxValue;
            float sameMax = normalMax + 1;

            System.Console.WriteLine($"{a}\n{b}\n{c}\n{d}\n{e}\n{f}\n"); 
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine($"{positiveInfinity}\n{negativeInfinity}\n{not}");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine($"{max}\n{overMax}");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine($"{megaMax}\n{ultraMax}\n\n{normalMax}\n{sameMax}\n");
        }
    }
}
