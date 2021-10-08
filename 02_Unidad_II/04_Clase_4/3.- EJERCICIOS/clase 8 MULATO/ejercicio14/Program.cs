using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = "trabajar, para ganar";

            char[] spearator = { ',', ' ' };
            Int32 count = 2;


            String[] strlist = str.Split(spearator,
                   count, StringSplitOptions.None);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
