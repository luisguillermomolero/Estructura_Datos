using System;

namespace aplicacionBase
{
    class program
    {
        static void Main(string[] args)
        {
            int longitudVectores;

            Console.Write("Digite la longitud de los dos vectores a operar: ");
            longitudVectores = int.Parse(System.Console.ReadLine());

            int [] VectorA = new int[longitudVectores];
            int [] VectorB = new int[longitudVectores];
            int [] VectorC= new int[longitudVectores];
            
            //rellenar aleatoriamente y mostrar el vector A
            Random numeroAleatorio = new Random();

            for (int i = 0; i < longitudVectores; i++)
            {
                VectorA[i] = numeroAleatorio.Next(1, 10);
                Console.WriteLine($" -> El valor de la posición {i + 1} del Vector A es {VectorA[i]}");
                VectorB[i] = numeroAleatorio.Next(1, 10);
                Console.WriteLine($" -> El valor de la posición {i + 1} del Vector B es {VectorB[i]}");

            }
            //swhitch y menu de opciones
            int Opcion;

            Console.WriteLine("\n<--Los Vectores A y B fueron llenados aleatoriamente.-->\n");
            Console.WriteLine("Menú");
            Console.WriteLine(" 1)Realizar C = A + B ");
            Console.WriteLine(" 2)Realizar C = B - A ");
            Console.Write("Seleccione une Opción: ");
            Opcion = int.Parse(System.Console.ReadLine());

            switch (Opcion)
            {
               case 1:
                    Console.WriteLine("\nC = A + B");
                    for (int i = 0; i < longitudVectores; i++)
                    {
                        VectorC[i] = VectorA[i] + VectorB[i];
                        Console.WriteLine($" ->Vector C Posición {i+1} = Vector A + Vector B => {VectorC[i]}");
                    }
                    break;
               case 2:
                    Console.WriteLine("\nC = B - A");
                    for (int i = 0; i < longitudVectores; i++)
                    {
                        VectorC[i] = VectorB[i]- VectorA[i] ;
                        Console.WriteLine($" ->Vector C Posición {i+1} = Vector B - Vector A => {VectorC[i]}");
                    }
                    break;
                default:
                    Console.WriteLine("\nOpción erronea");
                    break;




            }
                
        }

    }
}

