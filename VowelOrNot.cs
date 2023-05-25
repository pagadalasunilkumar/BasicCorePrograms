using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet:");
            string input = Console.ReadLine();
            char alphabet;

            // Validate the input
            while (!char.TryParse(input, out alphabet) || !char.IsLetter(alphabet))
            {
                Console.WriteLine("Invalid input. Please enter a valid alphabet:");
                input = Console.ReadLine();
            }

            alphabet = char.ToLower(alphabet);

            if (IsVowel(alphabet))
            {
                Console.WriteLine($"{alphabet} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{alphabet} is a consonant.");
            }
        }

        static bool IsVowel(char alphabet)
        {
            // Check if the alphabet is a vowel
            return alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u';
        }
    }
}
