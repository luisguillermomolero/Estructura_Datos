using System;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "*****0000abc000****";


            char[] charsToTrim1 = { '*', '0' };

            string s2 = "abc  ";
            string s3 = "  -GFG-  ";
            string s4 = "  AgeforAge";

            Console.WriteLine("antes:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine("");

            Console.WriteLine("despues:");

            Console.WriteLine(s1.TrimEnd(charsToTrim1));

            Console.WriteLine(s2.TrimEnd());

            Console.WriteLine(s3.TrimEnd('-'));

            Console.WriteLine(s4.TrimEnd(' ', 'A', 'g', 'e'));
        }
    }
}
