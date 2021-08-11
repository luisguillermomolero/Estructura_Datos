using System;

namespace AplicacionBase{
    class Program{
    static void Main(string[] args)
    {
        DisplayWeatherReport(15.0);  // Output: Cold.
        DisplayWeatherReport(24.0);  // Output: Perfect!

        void DisplayWeatherReport(double tempInCelsius){   
        
            if (tempInCelsius < 20.0)
                {
                    Console.WriteLine("Cold.");
                }
            else    
                {
                    Console.WriteLine("Perfect!");
                }
        }
    }
}
