using System;
using System.Text;

namespace ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();

            for (int j = 0; j < 5; j++)
            {
                str.Append(j).Append(" ");
            }
            Console.WriteLine(str);
        }
    }
}
