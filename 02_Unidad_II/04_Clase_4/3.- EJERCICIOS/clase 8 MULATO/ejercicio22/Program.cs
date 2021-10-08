using System;
using System.Text;

namespace ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            object[] var4 = { 3, 4.4, 'X' };

            sb.AppendFormat("4) {0}, {1}, {2}", var4);
            Console.WriteLine(sb.ToString());
        }
    }
}
