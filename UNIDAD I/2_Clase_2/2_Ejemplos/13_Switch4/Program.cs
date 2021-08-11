//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

using System;

namespace AplicacionBase{
        class Program
    {

        static void Main(string[] args){

        DisplayMeasurements(3, 4);  // Output: First measurement is 3, second measurement is 4.
        DisplayMeasurements(5, 5);  // Output: Both measurements are valid and equal to 5.

        void DisplayMeasurements(int a, int b)
        {
            switch ((a, b))
            {
                case (> 0, > 0) when a == b:
                    Console.WriteLine($"Both measurements are valid and equal to {a}.");
                    break;

                case (> 0, > 0):
                    Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
                    break;

                default:
                    Console.WriteLine("One or both measurements are not valid.");
                    break;
            }
        }
    }
}
}