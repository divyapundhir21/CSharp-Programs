/*
Problem:
Calculate the grade of a student based on the marks entered.

Algorithm:
1. Read the marks from the user.
2. If marks are less than 0 or greater than 100, print "Invalid marks."
3. Else if marks are 90 or above, print "Grade A+".
4. Else if marks are 80 or above, print "Grade A".
5. Else if marks are 70 or above, print "Grade B".
6. Else if marks are 60 or above, print "Grade C".
7. Else if marks are 50 or above, print "Grade D".
8. Otherwise, print "Fail".

Input:
85

Output:
Grade A

Time Complexity:
O(1)

Space Complexity:
O(1)
*/

using System;

namespace CSharpPrograms
{
    internal class GradeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks.");
            }
            else if (marks >= 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}