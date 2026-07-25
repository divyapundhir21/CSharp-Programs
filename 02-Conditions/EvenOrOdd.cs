/*
Problem:
Determine whether a given number is even or odd.

Algorithm:
1. Read a number from the user.
2. Check if the number is divisible by 2.
3. If the remainder is 0, print "Even".
4. Otherwise, print "Odd".

Input:
7

Output:
7 is Odd.

Time Complexity:
O(1)

Space Complexity:
O(1)
*/
using System;

namespace CSharpPrograms
{
    internal class EvenOrOdd
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even.");
            }
            else
            {
                Console.WriteLine($"{num} is Odd.");

            }

        }
    }
}