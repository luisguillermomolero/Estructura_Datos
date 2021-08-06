using System;
using System.Threading;

namespace algoritmo19
{
    class Program
    {
        
        private static string entrada;


        static void Main(string[] args)
        {
            //declaracion de variables 
            int n;
            int contador = 0;
            int i = 0;
            int f = 0,a=0,b=0,c=0,d=0,e=0,l=0,g=0,h=0,j=0;
            //ciclo do while para cuando el usuario digite 0 se termine el proceso
            do
            {
                for ( i = 0; i == 0; i++)
                    Console.WriteLine("hola estudiante danos la calificacion de la comida");//entrada de datos sobre la calificacion de la comida
                entrada = Console.ReadLine();
                n = Convert.ToInt32(entrada);
                contador = contador + i ;//contador para saber la cantidad de encuestados
               // ciclos if para cada una de las respuestas posibles para saber cauntos encuestados dieron esa respuesta 
                if (n == 1)
                {
                    f = f + 1;
                    

                }
                if (n == 2)
                {
                    a = a + 1;


                }
                if (n == 3)
                {
                    b = b + 1;


                }
                if (n == 4)
                {
                    c = c + 1;


                }
                if (n == 5)
                {
                    d = d + 1;


                }
                if (n == 6)
                {
                    e= e + 1;


                }
                if (n == 7)
                {
                    g = g + 1;


                }
                if (n == 8)
                {
                    h = h + 1;


                }
                if (n == 9)
                {
                    j = j + 1;


                }
                if (n == 10)
                {
                    l = l + 1;


                }



            } while (n != 0);
            //salida e imprecion de datos 
            Console.WriteLine("el numero de encuestados fue de : "+contador);
            Console.WriteLine("los estudiantes que calificaron la comida como 1 fueron " + f);
            Console.WriteLine("los estudiantes que calificaron la comida como 2 fueron " + a);
            Console.WriteLine("los estudiantes que calificaron la comida como 3 fueron " + b);
            Console.WriteLine("los estudiantes que calificaron la comida como 4 fueron " + c);
            Console.WriteLine("los estudiantes que calificaron la comida como 5 fueron " + d);
            Console.WriteLine("los estudiantes que calificaron la comida como 6 fueron " + e);
            Console.WriteLine("los estudiantes que calificaron la comida como 7 fueron " + g);
            Console.WriteLine("los estudiantes que calificaron la comida como 8 fueron " + h);
            Console.WriteLine("los estudiantes que calificaron la comida como 9 fueron " + j);
            Console.WriteLine("los estudiantes que calificaron la comida como 10 fueron " + l);


        }
        
           


            
    }    
}
