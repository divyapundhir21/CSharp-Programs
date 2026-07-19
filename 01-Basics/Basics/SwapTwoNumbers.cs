/*
Problem:

Input:
2
5

Output:
5
2
Notes: C# 6 introduced String Interpolation ($)
The $ tells C#:
"This string contains variables or expressions inside {}. Replace them with their values."

*/
using System;

namespace CSharpPrograms
{
    internal class SwapTwoNumbers
    {
        public static void Run()
        {
            int temp;
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swapping: num1 = {num1}, num2 = {num2}");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swapping: num1 = {num1}, num2 = {num2}");
        }
    }
}