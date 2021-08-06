using System;

namespace ejercicio10
{
    class Program
    {
        

        static void Main(string[] args)
        {
			int central;
			int i;
			int imp;
			Random random = new Random();
			do
			{
				Console.WriteLine("por favor digite un numero impar si es tan amable");
				imp = int.Parse(Console.ReadLine());
			} 
			while (imp % 2 != 1);


			int[] aleatorios = new int[imp];

			

			for (i = 0; i <= imp-1; i++)
			{
				var see = Environment.TickCount;

				aleatorios[i] = random.Next (0,20);
				Console.WriteLine(aleatorios[i]);
			}

			central = (imp / 2);
			Console.WriteLine("pocicion central: " + aleatorios[central]);
		}
    }
}
