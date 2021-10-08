using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ani\u00ADmal";
            string s2 = "animal";

            // encuentra el indice del ultimo guion
            Console.WriteLine(s1.LastIndexOf("\u00AD"));
            Console.WriteLine(s2.LastIndexOf("\u00AD"));

            // encuentra el indice del ultimo guion seguido de n
            Console.WriteLine(s1.LastIndexOf("\u00ADn"));
            Console.WriteLine(s2.LastIndexOf("\u00ADn"));

            // encuentra el idice del ultimo guion seguido de m
            Console.WriteLine(s1.LastIndexOf("\u00ADm"));
            Console.WriteLine(s2.LastIndexOf("\u00ADm"));
        }
    }
}
