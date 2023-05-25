using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class quotient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend:");
            string dividendInput = Console.ReadLine();
            int dividend;

            // Validate the dividend input
            while (!int.TryParse(dividendInput, out dividend))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
                dividendInput = Console.ReadLine();
            }

            Console.WriteLine("Enter the divisor:");
            string divisorInput = Console.ReadLine();
            int divisor;

            // Validate the divisor input
            while (!int.TryParse(divisorInput, out divisor) || divisor == 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-zero integer:");
                divisorInput = Console.ReadLine();
            }

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }
    }
}
