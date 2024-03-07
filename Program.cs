using System;

namespace Conditionals_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // asks user to enter whole number and assigns to integer variable
            Console.WriteLine("Enter a whole number.");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // checks if positive or negative
            if (myWholeNum >= 0) 
            {
                Console.WriteLine($"{myWholeNum} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number.");
            }

            // checks if even or odd
            if (myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number.");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number.");
            }

            // create two or more integer numbers
            int num1 = 6;
            int num2 = 99;

            // gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            // gets maximum number
            int max = Math.Max(firstMax, num2);

            //prints max to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}.");

            // asks user to enter a grade and assigns it to a char variable, grade
            Console.WriteLine("Enter a grade (A, B, C, D, F).");
                char grade = Console.ReadKey().KeyChar;

            // prints description based on grade value
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade.");
                    break;
            }

        }
    }
}