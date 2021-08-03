using System;

namespace algoritmo12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random aleatorio = new Random(); // declaro la variable random para generar numeros aleatorios
            int num;
            int de = 0, re = 0, bu = 0, ex = 0;
            do
            {
                num = aleatorio.Next(0, 20);
                Console.WriteLine("la nota generada es :" + num);// se genera la nota aleatoria
                if (num <= 5)                                   // segun la nota generada se genera el cilo if para saber a que tipo de nota pertenece
                {

                    de = de + 1;
                }
                if (num >= 6 && num >= 10)//ciclo para regular
                {

                    re = re + 1;

                }
                if (num >= 11 && num <= 15)//ciclo para bueno
                {

                    bu = bu + 1;
                }
                if (num >= 16 && num <= 20)// ciclo para excelentes
                {

                    ex = ex + 1;
                }

             
            } while (num != 5);// mientras se obtenga la variable 5 se detendra las notas aleatorias se peude colocar cualquier numero

            // se imprimen las imagenes de manera correcta 
            Console.WriteLine("la cantidad de estudiantes deficiente son : " + de);
            Console.WriteLine("la cantidad de estudiantes regular son : " + re);
            Console.WriteLine("la cantidad de estudiantes buenos son : " + bu);
            Console.WriteLine("la cantidad de estudiantes excelentes son : " + ex);
        
            
        }
    }
}
