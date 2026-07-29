/*
Problem:
Check whether the entered character is an alphabet, a digit, or a special character.

Algorithm:
1. Read the input as a string.
2. Check if the input contains exactly one character.
3. If not, print "Please enter a single character."
4. Store the character in a variable.
5. If it is an alphabet, print "Alphabet".
6. Else if it is a digit, print "Digit".
7. Otherwise, print "Special Character".

Input:
A

Output:
A is an Alphabet

Time Complexity:
O(1)

Space Complexity:
O(1)
*/

using System;

namespace CSharpPrograms
{
    internal class CharacterType
    {
        public static void Run()
        {
            Console.Write("Enter a character: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
            {
                Console.WriteLine("Please enter a single character.");
                return;
            }

            char ch = input[0];

            if (char.IsLetter(ch))
            {
                Console.WriteLine($"{ch} is an Alphabet");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"{ch} is a Digit");
            }
            else
            {
                Console.WriteLine($"{ch} is a Special Character");
            }
        }
    }
}