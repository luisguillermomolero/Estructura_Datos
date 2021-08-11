using System;

namespace AplicacionBase
{
    public class Program{

    static void Main(string[] args){

        DisplayMeasurement(45);  // Output: The measurement value is 45
        DisplayMeasurement(-3);  // Output: Warning: not acceptable value! The measurement value is -3

        void DisplayMeasurement(double value)
        {
            if (value < 0 || value > 100)
            {
                Console.Write("Warning: not acceptable value! ");
            }

            Console.WriteLine($"The measurement value is {value}");
        }
    }
}

}