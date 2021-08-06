using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////La forma de presentacion el ejercicio esta ligramente modificada a la guia\n por por cuestiones esteticas, pero la esencia y la logica del ejercicio es la misma////\n");
            int longi, i;
            string ingreso;
            Console.WriteLine("Digite la longitud que quiere designar a los vectores");
            ingreso = Console.ReadLine();
            longi = Convert.ToInt32(ingreso);
            int [] vectorc= new int[longi];

            //rellenar aleatoriamente y mostrar el vector A
            int[] vectora;
            vectora = new int[longi];
            Random aleo = new Random();
            for (i = 0; i < longi; i++)
            {
                vectora[i] = Convert.ToInt32(aleo.Next(-100, 100));
            }
            Console.WriteLine("\n");
            for (i = 0; i < longi; i++)
            {
                Console.WriteLine("El valor de la posición " + (i + 1) + " del vector A es [" + vectora[i] + "] ");
            }

            //rellenar aleatoriamente y mostrar el vector B
            int[] vectorb;
            vectorb = new int[longi];
            Random alea = new Random();
            for (i = 0; i < longi; i++)
            {
                vectorb[i] = Convert.ToInt32(alea.Next(-100, 100));
            }
            Console.WriteLine("\n");
            for (i = 0; i < longi; i++)
            { 
                Console.WriteLine("El valor de la posición " + (i + 1) + " del vector B es [" + vectorb[i] + "] ");
            }



            //swhitch y menu de opciones
            int opt;
            string entrada;
            Console.WriteLine("\n");
            Console.WriteLine("Los vectores A y B se han llenado de manera aleatoria, por favor digite un numero para seleccionar una opcion del menú\n 1)Realizar C=A+B\n 2)Realizar C=B-A\n");
            entrada = Console.ReadLine();
            opt = Convert.ToInt32(entrada);

            switch (opt)
            {
               case 1:
                    Console.WriteLine("\nUsted a seleccionado la opcion 1) Hacer C=A+B");
                    Console.WriteLine("\n");
                    for (i = 0; i < longi; i++)
                    {
                        vectorc[i] = vectora[i] + vectorb[i];
                        Console.WriteLine("El valor de la posición " + (i + 1) + " del vector es [" + vectorc[i] + "] ");
                    }
                    break;


               case 2:
                    Console.WriteLine("\nUsted a seleccionado la opcion 2) Hacer C=B-A");
                    Console.WriteLine("\n");
                    for (i = 0; i < longi; i++)
                    {
                        vectorc[i] = vectorb[i]- vectora[i] ;
                        Console.WriteLine("El valor de la posición " + (i + 1) + " del vector es [" + vectorc[i] + "] ");
                    }
                    break;


                default:
                    Console.WriteLine("\nUsted no selecciono una de las opciones anteriormente mostradas");
                    break;




            }
                
        }

    }
}

