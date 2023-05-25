using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int number;

            // Validate the input
            while (!int.TryParse(input, out number) || number <= 1)
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 1:");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Prime factors of {number}:");
            Console.WriteLine("--------------------------");

            // Compute the prime factorization
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            if (number > 1)
            {
                Console.WriteLine(number);
            }
        }       }
}
