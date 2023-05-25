using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class RandomFlipCoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of times to flip the coin:");
            string input = Console.ReadLine();
            int numberOfFlips;

            // Validate the input
            while (!int.TryParse(input, out numberOfFlips) || numberOfFlips <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
                input = Console.ReadLine();
            }

            int headsCount = 0;
            int tailsCount = 0;

            Random random = new Random();

            // Flip the coin
            for (int i = 0; i < numberOfFlips; i++)
            {
                if (random.NextDouble() < 0.5)
                    tailsCount++;
                else
                    headsCount++;
            }

            // Calculate the percentages
            double headsPercentage = (double)headsCount / numberOfFlips * 100;
            double tailsPercentage = (double)tailsCount / numberOfFlips * 100;

            // Print the results
            Console.WriteLine($"Heads: {headsCount} ({headsPercentage}%)\nTails: {tailsCount} ({tailsPercentage}%)");
        }
    }
}
