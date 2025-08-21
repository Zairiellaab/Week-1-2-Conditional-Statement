using System;

namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice 01.2:

            int number = -10;

            if (number > 0)
            {
                Console.WriteLine($"the number {number} is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"the number {number} is negative");
            }
        }
    }
}
