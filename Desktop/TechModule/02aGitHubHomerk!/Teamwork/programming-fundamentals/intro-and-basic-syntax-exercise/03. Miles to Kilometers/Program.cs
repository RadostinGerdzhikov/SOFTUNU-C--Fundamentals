using System;

namespace Milescalc
{
    class Program
    {
        static void Main(string[] args)
        {
          
		   //We recieve from the Console the miles -> a double
            var miles1 = double.Parse(Console.ReadLine());
            
			
			// We calculate miles in kilometers with formula from Internet shows that one mile is equal 1.60934 km.
            var km1 = miles1 * 1.60934;
            
			// We print the finish result form program
            Console.WriteLine("{0:F2}", km1);

        }
    }
}