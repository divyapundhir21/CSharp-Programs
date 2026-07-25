/*
Problem:
Determine whether a given number is positive, negative, or zero.

Algorithm:
1. Read a number from the user.
2. If the number is greater than 0, print "Positive".
3. Else if the number is less than 0, print "Negative".
4. Otherwise, print "Zero".

Input:
-15

Output:
The number is Negative.

Time Complexity:
O(1)

Space Complexity:
O(1)
*/
using System;

namespace CSharpPrograms
{
    internal class PositiveNegativeOrZero
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} is Positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is Negative.");
    
            }
            else
            {
                Console.WriteLine($"{num} is Zero.");
            }
            
        }
    }
}