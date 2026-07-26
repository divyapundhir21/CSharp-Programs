/*
Problem:
Check whether a number is divisible by both 5 and 11.

Algorithm:
1. Read a number from the user.
2. Check if the number is divisible by both 5 and 11 using the modulus (%) operator.
3. If both conditions are true, print "Number is divisible by 5 and 11."
4. Otherwise, print "Number is not divisible by 5 and 11."

Input:
55

Output:
Number is divisible by 5 and 11.

Time Complexity:
O(1)

Space Complexity:
O(1)
*/

using System;

namespace CSharpPrograms
{
    internal class DivisibleBy5And11
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 5 == 0 && number % 11 == 0)
            {
                Console.WriteLine("Number is divisible by 5 and 11.");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 and 11.");
            }
        }
    }
}