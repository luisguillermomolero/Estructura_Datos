using System;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {

            int est;
            int horrible =0;
            int tot_horrible = 0;
            int aceptable =0;
            int tot_aceptable = 0;
            int exelente =0;
            int tot_exelente = 0;
            int i;

            Console.WriteLine("buenas tardes directivos vamos a saber que piensan los estudiantes sobre la comida de la cafeteria");
            Console.WriteLine("");
            Console.WriteLine("primero digite cuantos estudiantes son");
            est = Convert.ToInt32(Console.ReadLine());

            int[] nota = new int[est];



            for (i = 0; i < est; i++)
            {
                Console.WriteLine("digiteme su calificacion de la comida entre los rangos de con 1 siendo horrible y 10 exelente");
                nota[i] = Convert.ToInt32(Console.ReadLine());

                if ((nota[i] >= 1)&&(nota[i] <= 4) )
                {
                    horrible += nota[i];
                    tot_horrible = tot_horrible + 1;
                }
                if ((nota[i] >= 5) && (nota[i] <= 7))
                {
                    aceptable += nota[i];
                    tot_aceptable = tot_aceptable + 1;
                }
                if ((nota[i] >= 8) && (nota[i] <= 10))
                {
                    exelente += nota[i];
                    tot_exelente = tot_exelente + 1;
                }
            }




            Console.WriteLine("");
            Console.WriteLine("la cantidad de estudiantes que piensan que la comida de la cafeteria es horrible es de: " + tot_horrible);
            Console.WriteLine("");
            Console.WriteLine("la cantidad de estudiantes que piensan que la comida de la cafeteria es aceptable es de: " + tot_aceptable);
            Console.WriteLine("");
            Console.WriteLine("la cantidad de estudiantes que piensan que la comida de la cafeteria es exelente es de:" + tot_exelente);
        }
    }
}
