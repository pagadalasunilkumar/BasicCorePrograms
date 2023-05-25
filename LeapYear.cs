using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year (4 digits):");
            string input = Console.ReadLine();
            int year;

            // Validate the input
            while (!int.TryParse(input, out year) || input.Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit year:");
                input = Console.ReadLine();
            }

            bool isLeapYear = false;

            // Check if it is a leap year
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
                {
                    isLeapYear = true;
                }
            }

            // Print the result
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
