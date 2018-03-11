using System;

namespace Milescalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles1 = double.Parse(Console.ReadLine());
            var km1 = miles1 * 1.60934;
            Console.WriteLine("{0:F2}", km1);
        }
    }
}