/*
Problem:Find Largest of Three Numbers

Algorithm:
1. Read three numbers.
2. Compare them.
3. Print the largest number.

Input:
Enter first number: 21
Enter second number: 21
Enter third number: 21

Output:
The all three numbers are equal: 21

*/
using System;

namespace CSharpPrograms
{
    internal class LargestOfThreeNumbers
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine($"The all three numbers are same: {num1}");
            }
            else if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"The largest number is: {num1}");
            }
            else if (num2 >= num3)
            {
                Console.WriteLine($"The largest number is: {num2}");
            }
            else
            {
                Console.WriteLine($"The largest number is: {num3}");
            }
        }
    }
}
