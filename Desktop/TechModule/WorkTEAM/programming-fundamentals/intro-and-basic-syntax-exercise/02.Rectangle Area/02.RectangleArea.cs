namespace _02.RectangleArea
{
    using System;

    public class RectangleArea
    {
        public static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(n * b):f2}");
        }
    }
}
