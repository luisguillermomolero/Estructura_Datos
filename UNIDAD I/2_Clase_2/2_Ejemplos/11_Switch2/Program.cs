using System;

namespace AplicacionBase{

    public class Program{

    static void Main(string[] args){

        DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
        DisplayMeasurement(5);  // Output: Measured value is 5.
        DisplayMeasurement(30);  // Output: Measured value is 30; too high.
        DisplayMeasurement(double.NaN);  // Output: Failed measurement.

        void DisplayMeasurement(double measurement)
        {
            switch (measurement)
            {
                case < 0.0:
                    Console.WriteLine($"Measured value is {measurement}; too low.");
                    break;

                case > 15.0:
                    Console.WriteLine($"Measured value is {measurement}; too high.");
                    break;

                case double.NaN:
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }
        }
    }
}
}