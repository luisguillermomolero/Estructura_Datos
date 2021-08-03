using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            
            int  ganador = 0, num = 0;
            Console.WriteLine("por favor digite la cantidad de competidores");//entrada de datos para saber cuantos competidores hay
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite el tiempo en minutos del competidor: "+(i));//entrada de datos de los minutos de cada competidor
                num = int.Parse(Console.ReadLine());

                if (i == 1)  // ciclo para saber quien es el ganador el que tena menor tiempo
                {
                    
                    ganador = num;
                }
                
                if (num < ganador) { ganador = num; }



                num = 0;
            }

            
            Console.WriteLine(" el ganador de la carrera es el competidor que marco el tiempo : " + ganador);// salida e imprecion del ganador 

        }
    }
}