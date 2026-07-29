/*
Problem:
Check whether an alphabet entered by the user is a vowel or a consonant.

Algorithm:
1. Read a character from the user.
2. Convert the character to lowercase.
3. Check if the input is a valid alphabet.
4. If it is 'a', 'e', 'i', 'o', or 'u', print "Vowel".
5. Otherwise, print "Consonant".

Input:
a

Output:
Vowel

Time Complexity:
O(1)

Space Complexity:
O(1)
*/

using System;

namespace CSharpPrograms
{
    internal class VowelOrConsonant
    {
        public static void Run()
        {
            Console.Write("Enter an alphabet: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
            {
                Console.WriteLine("Please enter a single alphabet.");
                return;
            }

            char ch = char.ToLower(input[0]);

            if (!char.IsLetter(ch))
            {
                Console.WriteLine("Invalid input. Please enter an alphabet.");
            }
            else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}