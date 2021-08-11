using System;

namespace AplicacionBase{
    public class Program{

    static void Main(string[] args){

        DisplayMeasurement(-4);  // Output: Measured value is -4; out of an acceptable range.
        DisplayMeasurement(50);  // Output: Measured value is 50.
        DisplayMeasurement(132);  // Output: Measured value is 132; out of an acceptable range.

        void DisplayMeasurement(int measurement)
        {
            switch (measurement)
            {
                case < 0:
                case > 100:
                    Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }
        }
    }
}
}