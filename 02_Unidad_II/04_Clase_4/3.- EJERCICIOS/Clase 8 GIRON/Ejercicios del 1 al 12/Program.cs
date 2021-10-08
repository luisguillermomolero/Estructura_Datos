using System;

namespace Ejercicios_del_1_al_12
{
    class Program
    {
        private static string entrada;
        static void Main(string[] args)
        {
            // el metodo ToString() lo utilizamos para convertir una variable a tipo string su implementación  devuelve el nombre completo del tipo de objeto
            string nombre;
            Console.WriteLine("ejercicio 1 clase object metodo ToString() ");
            Console.WriteLine("como te llamas");
            entrada = Console.ReadLine();
            nombre = Convert.ToString(entrada);
            Console.WriteLine("tu nombre es : {0} ", nombre);

            Console.WriteLine("____________________________________________________________");
            // el metodo Datatime lo utilizamos para saber una fecha que registramos en este caso vamos a saber mi fehca de nacimiento 
            Console.WriteLine("");
            Console.Write("ejercicio 2 metodo Datatime");
            Console.WriteLine("");
            //utilizamos el metodo Datatime y var
            var data = new DateTime(2002, 11, 09);
            Console.WriteLine(" yo Jose Herbet Giron Rojas naci el : ");
            Console.WriteLine((data));
            Console.WriteLine("");
            Console.WriteLine("__________________________________________");
            // el metodo concat() nos sirve para unir o invertir el orden de los variables que tengamos 
            Console.WriteLine("ejercicio 3 metodo concat()");
            const int tamaño = 5;
            //tenemso un arreglo de 5 caracteres por palabra 
            string[] palabras = { "Jugar", "Volar", "Tocar" };
            double[] llaves = new double[tamaño];
            string[] letras = new string[tamaño];
            Random rn = new Random();
            foreach (string palabra in palabras)
            {
                for (int c = 0; c < palabra.Length; c++)
                {
                    llaves[c] = rn.NextDouble();
                    letras[c] = palabra[c].ToString();
                }

                Array.Sort(llaves, letras, 0, tamaño);
                //utilizamos el metodo concat y concatenamos las palabras 
                string concatenada = string.Concat(letras[0], letras[1], letras[2], letras[3]);
                Console.WriteLine("la palabra concatenada es :");
                Console.WriteLine("{0}-> {1}", palabra, concatenada);
            }

            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("");
            // metodo Compare() un metodo utilizado para comparar dos o mas variables 
            Console.WriteLine("ejercicio 4 metodo Compare()");
            string v = "jose";
            string b = "Jose";
            Console.WriteLine("comparando : {0} y {1}", v, b);
            //utilizamos el metodo Compare() junto ToUpper para asi saber si el valor es falso /verdadero
            Console.WriteLine("no son iguales {0}", string.Compare(v.ToUpper(), b.ToUpper()) == 0);

            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            // el metodo Equals() lo utilizamos para saber si dos o mas variables son iguales o no 
            Console.WriteLine("ejercicio 5 metodo Equals()");
            string p1;
            string p2;
            Console.WriteLine("");
            // el usuario digita la primera palabra 
            Console.WriteLine("ingresa una palabra ");
            p1 = Console.ReadLine();
            Console.WriteLine("");
            // el usuario digita la segunda plabra 
            Console.WriteLine("ingresa otra plabra");
            p2 = Console.ReadLine();
            // creamos una variable de tipo bool para hacer la comparacion con el metodo Equals()
            bool comparacion = p1.Equals(p2);
            // creamos un cilo if con valor falso /verdadero 
            if (comparacion == true)
            {
                Console.WriteLine("ambas palabras son iguales");
            }
            else
            {
                Console.WriteLine("las palabras son diferentes");
            }

            Console.WriteLine("________________________________________________________________________________");
            //el metodo Contains() lo utilizamos para saber una variable se encuentra dentro de otra en este caso la palabra "perdon" en la oracion 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ejercicio 6 metodo Contains() ");
            Console.WriteLine("");
            string w1 = "perdon por el retraso me perdi por el sendero de la vida ";
            string w2 = "perdon";
            // creamos una variable tipo bool junto al metodo Contains()
            bool k = w1.Contains(w2);
            Console.WriteLine("{0} esta en la oracion : {1}  : {2} ", w2, w1, k);

            Console.WriteLine("_____________________________________________________________");
            // En este ejercicio vamos a usar dos metodos en uno el substring () y Indexof() el metodo substring lo utilizamos para simplificar una variable tipo string en una cadena en una variable mas simplificada 
            // el metodo indexof() para saber desde que punto se debe recortar la informacion 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ejercicio 7 metodo substring() y Indexof()");
            string[] informacion = { "Nombre : Jose Giron ", "Edad: 18", "Carrera: Ingenieria software ", "Universidad: Unipanamericana " };
            int simplificacion = 0;
            //creamos un arreglo con datos personales 
            Console.WriteLine("los datos iniciales del arreglo son : ");
            foreach (string d in informacion)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("");
            Console.WriteLine("los datos pero mas simplificados usando el metodo substring() ");
            Console.WriteLine("");
            foreach (string d in informacion)
            {
                // el metodo Indexof() lo utilizamos para que corte la informacion hasta los dos puntos : 
                simplificacion = d.IndexOf(": ");
                // y el substring para recuperar la informacion de la cadena string 
                Console.WriteLine("{0}", d.Substring(simplificacion + 2));
            }

            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Ejercicio 8");
            Console.WriteLine("metodo StartsWith() y EndsWith()");
            Console.WriteLine();
            //En este ejerccio comprovaremos las dioverentes variables que nos da este metodo
            //Este metodo funciona de la forma que "StartsWith()" nos señala cual es la parte inicial y 
            //"EndsWith()" nos va a señalizar la parte final, esto nos lo demuestra diciendonos si es "true" o "Flase"

            string Na = "Hola que tal - Si buenas";
            Console.WriteLine(Na);
            Console.WriteLine();

            //Aqui miraremos si las dos son verdaderas
            Console.WriteLine("incia en 'Hola'");
            Console.WriteLine(Na.StartsWith("Hola"));
            Console.WriteLine("Finaliza en 'as'");
            Console.WriteLine(Na.EndsWith("as"));
            Console.WriteLine();

            //Aquí si las dos son falsas
            Console.WriteLine("inicia en 'FF'");
            Console.WriteLine(Na.StartsWith("FF"));
            Console.WriteLine("Finaliza en 'CC'");
            Console.WriteLine(Na.EndsWith("CC"));
            Console.WriteLine();

            //Y por ultimo si una es verdadera o falsa 
            Console.WriteLine("Inicia en 'Hola'");
            Console.WriteLine(Na.StartsWith("Hola"));
            Console.WriteLine("Finaliza en 'ZZ'");
            Console.WriteLine(Na.EndsWith("ZZ"));
            Console.WriteLine();


            Console.WriteLine("");
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("ejercicio 10 metodo Insert()");
            // el metodo Insert() lo utilizamos para insertar una variable dentro de otra
            Console.WriteLine("");
            string or = "Hola   Profe";
            // la variable original
            Console.WriteLine("las palabras origininales son : {0 }", or);
            string co = or.Insert(5, "como esta");
            // lavariable que se espera insertar 
            Console.WriteLine("las palabras insertas cone l metodo Insert(): {0}", co);
            Console.WriteLine("");
            Console.WriteLine("_____________________________________________________________________");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ejercicio 11 metodo Padleft()");
            // el metodo Padleft() lo usamos para agregar un caracter hasta completar el numero de caracteres deseados hacia la izquierda
            Console.WriteLine("");
            string word = "Aquellos que no son capaces de reconocerse a sí mismos esta destinados a fracasar";
            char pad = '.';
            // colocamos que agregue un punto . hasta completar 95 caracteres 
            Console.WriteLine(word.PadLeft(95, pad));
        }
    }
}