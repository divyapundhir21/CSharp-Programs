/*
Problem:

Input:

Output:

Approach:

Time Complexity:

Space Complexity:
*/
using System;

namespace CSharpPrograms
{
    internal class LeapYear
    {
        public static void Run()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is Not a Leap Year.");
            }
        }
    }
}