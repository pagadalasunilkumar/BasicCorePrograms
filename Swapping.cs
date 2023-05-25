using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Swapping
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

            Console.WriteLine($"Before swapping: First number = {firstNumber}, Second number = {secondNumber}");

            // Swap the numbers using a temporary variable
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine($"After swapping: First number = {firstNumber}, Second number = {secondNumber}");
        }
    }
}
