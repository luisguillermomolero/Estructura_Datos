using System;

namespace AplicacionBase
{
    public class Program
    {

        static void Main(string[] args)
        {

            DisplayCharacter('f');  // Output: A lowercase letter: f
            DisplayCharacter('R');  // Output: An uppercase letter: R
            DisplayCharacter('8');  // Output: A digit: 8
            DisplayCharacter(',');  // Output: Not alphanumeric character: ,

            void DisplayCharacter(char ch)
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine($"An uppercase letter: {ch}");
                }
                else if (char.IsLower(ch))
                {
                    Console.WriteLine($"A lowercase letter: {ch}");
                }
                else if (char.IsDigit(ch))
                {
                    Console.WriteLine($"A digit: {ch}");
                }
                else
                {
                    Console.WriteLine($"Not alphanumeric character: {ch}");
                }
            }
        }
    }
}