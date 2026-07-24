/*
Problem: Check if the year is the leap year

Input:1901

Output: Not a leap year

Approach: A year is a leap year if it is divisible by 400, or if it is divisible by 4 but not divisible by 100. This handles century years correctly because years like 1900 are divisible by 100 but not by 400, so they are not leap years, while years like 2000 are divisible by 400 and therefore are leap years.

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