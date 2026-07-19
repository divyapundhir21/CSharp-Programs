/*
Problem: Add two integer numbers

Input: 
2 
3

Output: 5

*/
using System;

namespace CSharpPrograms
{
    internal class AddTwoNumbers
    {
        public static void Run()
        {
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            
        }
    }
}