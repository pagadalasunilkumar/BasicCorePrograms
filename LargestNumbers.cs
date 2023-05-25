using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string firstNumberInput = Console.ReadLine();
            int firstNumber;

            // Validate the first number input
            while (!int.TryParse(firstNumberInput, out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
                firstNumberInput = Console.ReadLine();
            }

            Console.WriteLine("Enter the second number:");
            string secondNumberInput = Console.ReadLine();
            int secondNumber;

            // Validate the second number input
            while (!int.TryParse(secondNumberInput, out secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
                secondNumberInput = Console.ReadLine();
            }

            Console.WriteLine("Enter the third number:");
            string thirdNumberInput = Console.ReadLine();
            int thirdNumber;

            // Validate the third number input
            while (!int.TryParse(thirdNumberInput, out thirdNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
                thirdNumberInput = Console.ReadLine();
            }

            int largestNumber = FindLargest(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine($"The largest number is: {largestNumber}");
        }

        static int FindLargest(int a, int b, int c)
        {
            // Find the largest number among a, b, and c
            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            return max;
        }
    }
}
