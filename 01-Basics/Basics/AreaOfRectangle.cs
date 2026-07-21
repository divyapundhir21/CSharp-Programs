/*
Problem: Area Of Rectangle

*/
using System;

namespace CSharpPrograms
{
    internal class AreaOfRectangle
    {
        public static void Run()
        {
            Console.WriteLine("Enter length of the rectangle");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of the rectangle");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int area = length * breadth;
            Console.WriteLine($"Area of Rectangle is = {area}");
        }
    }
}