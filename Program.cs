using System;

namespace Conditionals_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // asks user to enter whole number and assigns to int variable
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

            int num1 = 6;
            int num2 = 99;

            int firstMax = Math.Max(myWholeNum, num1);
            int max = Math.Max(firstMax, num2);

            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}.");

        }
    }
}