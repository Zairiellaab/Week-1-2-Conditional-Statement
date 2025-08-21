using System;

namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice 01.4:
            int examGrade = 50;

            string result = (examGrade >= 50) ? "You Passed the exam!" : "You Failed the exam!";
            Console.WriteLine(result);
        }
    }
}
