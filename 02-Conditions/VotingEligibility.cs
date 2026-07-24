/*
Problem:
Check whether a person is eligible to vote.

Algorithm:
1. Read the person's age.
2. If age is less than 0, print "Invalid age."
3. Else if age is greater than or equal to 18, print "Eligible to vote."
4. Otherwise, print "Not eligible to vote."

Input:
18

Output:
Eligible to vote.

Time Complexity:
O(1)

Space Complexity:
O(1)
*/
using System;

namespace CSharpPrograms
{
    internal class VotingEligibility
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote.");
            }
            else
            {
                Console.WriteLine("Not eligible to vote.");
            }
        }
    }
}