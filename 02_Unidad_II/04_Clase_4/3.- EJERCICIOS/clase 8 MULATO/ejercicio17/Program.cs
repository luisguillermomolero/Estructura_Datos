using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = " AGE";
            string s2 = " AGE ";
            string s3 = "AGE ";


            Console.WriteLine("antes:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine("");

            Console.WriteLine("despues:");
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s3.Trim());
        }
    }
}
