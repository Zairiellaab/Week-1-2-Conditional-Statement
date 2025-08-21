using System;

namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice 01.5:

            Console.WriteLine("\n A for Area \n P for Perimeter \n X for Exit ");
            Console.Write("Chose you Computing method: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "A":
                    Console.Write("Enter the Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area = 3.14 * radius * radius;
                    Console.WriteLine($"The area is: {area}");
                    break;
                case "P":
                    Console.Write("Enter the Perimeter: ");
                    double perimeterRadius = Convert.ToDouble(Console.ReadLine());
                    double Perimeter = 2 * 3.14 * perimeterRadius;
                    Console.WriteLine($"The perimeter is: {Perimeter}");
                    break;
                case "X":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
            }
        }
    }
}
