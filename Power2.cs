using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Power2
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a value for N as a command-line argument.");
                return;
            }

            int n;
            if (!int.TryParse(args[0], out n) || n < 0 || n >= 31)
            {
                Console.WriteLine("Invalid input. N should be an integer between 0 and 30.");
                return;
            }

            Console.WriteLine("Powers of 2:");
            Console.WriteLine("-------------");

            for (int i = 0; i <= n; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {power}");
            }
        }
    }
}
