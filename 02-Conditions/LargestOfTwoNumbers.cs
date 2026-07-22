/*
Problem:Find Largest of Two Numbers

Algorithm:
1. Read two numbers.
2. Compare them.
3. Print the larger number.

Input:
10
20

Output:
20

*/
using System;

namespace CSharpPrograms
{
    internal class LargestOfTwoNumbers
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The larger number is: {num1}");
            }
            else if(num2>num1)
            {
                Console.WriteLine($"The larger number is: {num2}");
            }
            else
                Console.WriteLine($"Both the numbers are equal: {num1}, {num2}");
        }
    }
}