using System;

namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice 01.3:
            int age = 26;
            int income = 50000;

            if (age >= 25 || age >= 35 && income >= 50000)
            {
                Console.WriteLine("You are a young professional and your age is between 25 and 35 years old and income is greater than Php 50000");
            }
            else if (age >= 36 || age >= 55 && income >= 70000)
            {
                Console.WriteLine("You are a middle age professional and your age is between 36 and 55 years old and income is greater than Php 70000");
            }
            else if (age >= 56 || income <= 30000)
            {
                Console.WriteLine("You are a senior citezen and your age is greater than 56 years old or older and income is less than Php 100000");
            }
            else
            {
                Console.WriteLine("You do not meet the criteria for any professional category.");
            }
        }
    }
}
