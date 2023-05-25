using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            string input = Console.ReadLine();
            int n;

            // Validate the input
            while (!int.TryParse(input, out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
                input = Console.ReadLine();
            }

            double harmonic = 0;

            // Calculate the harmonic number
            for (int i = 1; i <= n; i++)
            {
                harmonic += 1.0 / i;
            }

            // Print the result
            Console.WriteLine($"The {n}th Harmonic Value is: {harmonic}");
        }
    }
}
