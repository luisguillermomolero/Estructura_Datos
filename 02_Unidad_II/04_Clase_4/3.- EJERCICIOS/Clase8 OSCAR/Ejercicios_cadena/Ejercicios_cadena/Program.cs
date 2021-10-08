using System;
using System.Data;
using System.Linq;
using System.Text;

namespace Ejercicios_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingresar;
            int op;

            // Hacemos un menú dentro de un ciclo while para que el usuario pueda revisar todos los ejercicios.
            do
            {

                Console.WriteLine("Por favor seleccione un ejercicio del menú:\n\n  1)  ToString().\n  2)  DaataTime.\n  3)  Concat().\n" +
                    "  4)  Compare().\n  5)  Equals().\n  6)  Contains().\n  7)  Substring().\n  8)  EndsWith().\n  9)  CopyTo().\n  10) Insert().\n  11) LastIndexOf().\n" +
                    "  12) PadLeft().\n  13) PadRight().\n  14) Remove().\n  15) Replace().\n  16) Split().\n  17) ToLower().\n  18) ToUppert().\n  19) Trim().\n  20) TrimStart().\n" +
                    "  21) TrimEnd().\n  22) Append()-constructores.\n  23) WriteLine()-constructores.\n  24) AppendFormat()-constructores.\n  25) ToString()-constructores. ");

                Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                ingresar = Console.ReadLine();
                op = Convert.ToInt32(ingresar);
                Console.WriteLine("---------------------------------------------------------------------------------------------------");

                switch (op)
                {
                    //Este ejercicio es con el metodo toString.
                    case 1:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a canvertir los numeros de cedula de 3 personas de tipo object a variables de tipo string");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos variables y las imprimimos
                        object c1 = 1003628463;
                        object c2 = 364885736;
                        object c3 = 1003746253;
                        Console.WriteLine("Estos son los 3 numeros de cedula de tipo object:\n\n  {0}\n  {1}\n  {2}", c1, c2, c3);

                        //Convertimos las variables a tipo string
                        c1 = c1.ToString();
                        c2 = c2.ToString();
                        c3 = c3.ToString();
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //imprimimos las variables de tipo String
                        Console.WriteLine("Estos son los 3 numeros de cedula de tipo string:\n\n  {0}\n  {1}\n  {2}", c1, c2, c3);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo DateTime
                    case 2:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio imprimiremos por pantalla la fecha de hoy y la de mañana utilizando DataTime");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestros DataTime, el primero con la fecha de hoy y al segundo le agregamos un dia, es decir con la fecha de mañana
                        DateTime fh = DateTime.Now;
                        DateTime fm = DateTime.Now.AddDays(1);

                        /*Imprimimos un mensaje por consola con la fecha de hoy y la de mañana utilizando ToShortDateString
                        para que el formato de la fecha sea corto y no salga el tipo de zona horaria (12:00)*/
                        Console.WriteLine("la fecha de hoy es: {0} y la de mañana sera: {1}",fh.ToShortDateString(),fm.ToShortDateString());
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo concat
                    case 3:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a concatenar 2 cadenas de caracteres, formando una sola frase");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos variables y asignamos valores de tipo string
                        string v1 = "Esperamos sacar buena ";
                        string v2 = "nota en este trabajo";

                        //Imprimimos el mensaje concatenado en este caso utilizando el signo +
                        Console.WriteLine(v1+v2);

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                       Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo compare
                    case 4:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio se definiran 2 palabras y se dira que palabra es mas larga");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos las dos palabras                      
                        string pal1 = "canica";
                        string pal2 = "canicas";

                        //Mostramos las dos palabras
                        Console.WriteLine("las dos palabras que utilizaremos son:\n\n 1) canica\n 2) canicas ");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Comparamos las dos palabras entre si
                        pal1.CompareTo(pal2);
                        pal2.CompareTo(pal1);

                        //Ponemos si condicionales con los mensajes a impririr en caso de que se cumplan o no las condiciones dadas
                        if (pal1.CompareTo(pal2) == 1)
                        {
                            Console.WriteLine("la palabra 1 es mas larga que la palabra 2");
                        }
                        else if (pal2.CompareTo(pal1) == 1)
                        {
                            Console.WriteLine("la palabra 2 es mas larga que la palabra 1");
                        }
                       
                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo equals
                    case 5:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a identificar si en una lista de 3 palbras hay alguna repetida");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos las cadenas y las imprimimos por pantalla
                        string pala1 = "carretera";
                        string pala2 = "automovil";
                        string pala3 = "carretera";
                        Console.WriteLine("Estas son las 3 palabras de la lista:\n\n1) {0}\n2) {1}\n3) {2}",pala1,pala2,pala3);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Hacemos las respectivas comparaciones
                        bool comp1 = pala1.Equals(pala2);
                        bool comp2 = pala1.Equals(pala3);
                        bool comp3 = pala2.Equals(pala3);

                        //ponemos si condicionales con los mensajes a imprimir en case de que se cumplan las condiciones
                        if       (comp1 == true)
                        {
                            Console.WriteLine("la palabra N°1 es la misma palabra N°2");
                        }else if (comp2 == true)
                        {
                            Console.WriteLine("la palabra N°1 es la misma palabra N°3");
                        }else if (comp3 == true)
                        {
                            Console.WriteLine("la palabra N°2 es la misma palabra N°3");
                        }
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo contains
                    case 6:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("Para este ejercicio se utilizara un detector de la palabra univero; es decir, si en la frase aparece la palabra --universo-- el programa lo detectara y lo advertira");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //definimos variables y asignamos las frases a cada una y las imprimimos
                        string frs1 = "la vida en si es un misterio. Es tan profunda e inentendible como el mismo universo";
                        string palabra = "universo";
                        Console.WriteLine("Esta es la frase en la que identificaremos si se encuentra escrita la palabra universo\n  Frase: {0}", frs1);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Hacemos las comparaciones utilizando el contains
                        bool compar = frs1.Contains(palabra);

                        //Ponemos si condicionales con los mensajes a impririr en caso de que se cumplan o no las condiciones dadas
                        if (compar == true)
                        {
                            Console.WriteLine("EN LA FRASE SI SE HA ENCONTRADO LA PALABRA {0}",palabra);
                        }else if (compar == false)
                        {
                            Console.WriteLine("En la frase no se ha encontrado la parabra {0}",palabra);
                        }
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo substring
                    case 7:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En es ejercicio deberemos extraer una sub cadena del inicio de una frase");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos la frase como una variable de tipo string y la imprimimos
                        string presentacion = "Buenos dias, mi nombre es juanito y tengo 18 años";
                        Console.WriteLine("Frase o cadena completa:\n{0}", presentacion);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        
                        //Extraemos la subcadena (en este caso el nombre de la persona) y lo imprimimos
                        string subc = presentacion.Substring(0,11);
                        Console.WriteLine("la subcadena extraida es: {0}",subc);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo Endswith
                    case 8:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a identificar si la siguiente frase termina con la palabra nacional utilizando el metodo Endswith");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Denifimos la frase como una variable de tipo string y la imprimimos
                        string frase = "La comunidad del Bronx fue desaloja por la policia nacional";
                        Console.WriteLine("Frase:\n{0}", frase);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos si condicionales con los mensajes a impririr en caso de que se cumplan o no las condiciones dadas
                        if (frase.EndsWith("nacional"))
                        {
                            Console.WriteLine("la frase si termina con la palabra nacional");
                        }
                        else
                        {
                            Console.WriteLine("la frase no termina con la palabra nacional");
                        }

                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo Copyto
                    case 9:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos copiar 10 letras del abecedario utilizando el metodo Copyto con un arreglo");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos el arreglo y la variable abecedario
                        string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
                        char[] arreglo;
                        arreglo = new char[10];

                        //Utilizamos el metodo CopyTo    
                        abecedario.CopyTo(0, arreglo, 0, 10);

                        //Imprimimos el arrreglo con los 10 primeros caracteres copiados
                        Console.WriteLine("Estas son las 10 primeras letras del abecedario:");
                        Console.WriteLine(arreglo);  
                        
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo insert
                    case 10:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a insertar una palabra al inicio de una oracion para completarla");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos la oracion como una variable de tipo string e imprimimos la frace inicial
                        string orac = "manejar mi coche";
                        string palabr = "yo se ";
                        Console.WriteLine("Oracion sin la palabra inicial:\n{0}",orac);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Mostramos en pantalla la palabra con las letras insertadas
                        Console.WriteLine("oracion completada con la palabra inicial:");
                        Console.WriteLine(orac.Insert(0, palabr)); 
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo LastIndexOf
                    case 11:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a identificar en que posicion de la siguiente frase se encuentra la la letra s, con el metodo lastindexof");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos la frase como una variable de tipo string
                        string fra = "El amor es como el fuego";
                        Console.WriteLine("Esta es la frase original:\n{0}",fra);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos la funcion LastIndexOf para saber en que posicion esta la letra s y la mostramos por pantalla con un mensaje
                        Console.WriteLine("la letra s esta ubicada en la posicion: {0} dentro de la frase",fra.LastIndexOf("s")+1 );

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo PadLeft
                    case 12:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio pondremos un caracter 5 veces antes de cierta palabra");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos como string la palabra y el caracter a agragar
                        string pala = "cuidado";
                        char ca1 = 'c';
                        Console.WriteLine("La palabra es {0} y el caracter a agregar es {1}", pala, ca1);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo padledft e imprimimos el resultado en pantalla
                        Console.WriteLine("Palabra modificada:\n");
                        string agg = pala.PadLeft(12, ca1);
                        Console.WriteLine(agg);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo Padright
                    case 13:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio pondremos un caracter 5 veces despues de cierta palabra");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos como string la palabra y el caracter a agragar
                        string pa = "cuidado";
                        char ca2 = 'o';
                        Console.WriteLine("La palabra es {0} y el caracter a agregar es {1}", pa, ca2);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo PadRight e imprimimos el resultado en pantalla
                        Console.WriteLine("Palabra modificada:\n");
                        string ag = pa.PadRight(12, ca2);
                        Console.WriteLine(ag);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo Remove
                    case 14:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a remover las primeras 4 letras de una frase utilizando el metodo Remove");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos variables de tipo string y las mostramos en pantalla
                        string str = "hola amigos";
                        Console.WriteLine("la frase original es: {0}", str);
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");

                        //Utilizamos el metodo e imprimimos los resultados en pantalla
                        string util = str.Remove(0, 4);
                        Console.WriteLine("la frase sin las primeras 4 letras es: {0}", util);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo replace
                    case 15:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a reemplazar una palabra por un sinonimo en un poema corto");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos variables de tipo string y las mostramos en pantalla
                        string poem = "Tan bello es el sol tan bonita es la luna a alguien como tu no la cambio por ninguna";
                        string reemplazo= "hermosa";
                        Console.WriteLine("El poema original es:\n{0}\n\n\nLa palabra a reemplazar es ----bonita---- y reemplazo sera: -----{1}----", poem,reemplazo);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo replace e imprimimos el resultado
                        string desps = poem.Replace("bonita", reemplazo);
                        Console.WriteLine("El poema modificado es:");
                        Console.WriteLine(desps);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");


                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo split
                    case 16:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a separar una copla, haciendo saltos de linea con un arreglo, utilizando el metodo split para cada lugar donde haya espacios");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestro arreglo, utilizando de una vez el metodo split y nuestra cadena de caracteres
                        string copla = "Del cielo cayo una rosa, juan Carlos la recogio, se la puso en la cabeza y que linda que quedo";
                        string[] arrg = copla.Split();
                        Console.WriteLine("La copla inicial es:\n{0}", copla);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Mostramos los resultados por pantalla utilizando un ciclo for para recorrer el arreglo
                        Console.WriteLine("La copla modificada es:\n");
                        for (int i = 0; i < copla.Length; i++)
                        {
                            Console.WriteLine(arrg[i]);
                        }
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo ToLower
                    case 17:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a pasar una oracion de mayusculas a minusculas utilizando el metodo ToLower");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestra oracion como variable de tipo string y la mostramos en pantalla
                        string oracion = "QUEREMOS PASAR EL SEMESTRE";
                        Console.WriteLine("la oracion original en mayusculas es:\n{0}", oracion);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo ToLower y mostramos los resultados en pantalla
                        Console.WriteLine("La oracion pasada a minusculas es:\n{0}", oracion.ToLower());
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo ToUppert
                    case 18:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a pasar una oracion de minusculas a mayusculas utilizando el metodo ToUppert");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestra oracion como variable de tipo string y la mostramos en pantalla
                        string oracion2 = "que bonito es programar";
                        Console.WriteLine("la oracion original en minusculas es:\n{0}", oracion2);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo ToUpper y mostramos los resultados en pantalla
                        Console.WriteLine("La oracion pasada a mayusculas es:\n{0}", oracion2.ToUpper());

                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo Trim
                    case 19:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a eliminar los signos $ que hay derecha y a la izquieda de una oracion, utilizando el metodo Trim");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestra oracion como variable de tipo string
                        string oraci = "$$$$$$$$$$$$$Los animales carnivoros comen carne$$$$$$$$$$$$$$$";
                        Console.WriteLine("La oracion original con los signos $ a la derecha y a la izquierda es:\n{0}", oraci);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo Trim para eliminar los espacios de ambos lados y mostramos el resultado en pantalla
                        Console.WriteLine("Esta es la oracion sin los signos $ ni a la derecha, ni a la izquierda despues de utilizar el metodo Trim");
                        Console.WriteLine(oraci.Trim('$'));
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo TrimStart
                    case 20:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a eliminar los signos % al inicio de una oracion, utiizando el metodo TrimStar");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestra oracion como variable de tipo string
                        string oraci2 = "%%%%%%%%%%%%%%%%%%%%%%%Los animales carnivoros comen carne";
                        Console.WriteLine("La oracion original con los signos % al inicio es:\n{0}", oraci2);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo TrimStar para eliminar los espacios de ambos lados y mostramos el resultado en pantalla
                        Console.WriteLine("Esta es la oracion sin los signos % al inicio, despues de utilizar el metodo TrimStar");
                        Console.WriteLine(oraci2.TrimStart('%'));
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        
                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo TrimEnd
                    case 21:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a eliminar los signos ? al final de una oracion, utiizando el metodo TrimEnd");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Definimos nuestra oracion como variable de tipo string
                        string oraci3 = "Los animales carnivoros comen carne??????????????????";
                        Console.WriteLine("La oracion original con los signos ? al final es:\n{0}", oraci3);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo TrimEnd para eliminar los espacios de ambos lados y mostramos el resultado en pantalla
                        Console.WriteLine("Esta es la oracion sin los signos ? al final, despues de utilizar el metodo TrimEnd");
                        Console.WriteLine(oraci3.TrimEnd('?'));
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metoo Append para constructores
                    case 22:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a agregar una serie de palabras con el metodo Append a nuestro constructor para formar una oracion");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //definimos nuestro constructor y lo mostramos por pantalla
                        StringBuilder constr = new StringBuilder("las llaves ");
                        Console.WriteLine("El constructor inicial solo contiene la frase: {0}",constr);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo Apped y mostramos los resultados en pantalla                       
                        constr.Append("sirven ").Append("para ").Append("prender el ").Append("carro.");
                        Console.WriteLine("El constructor resultante despues de haber agregado las otras palabras es:");
                        Console.WriteLine(constr);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo WriteLine para constructores
                    case 23:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a escribir en una nueva linea lo que esta dentro de un constructor");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //definimos nuestro constructor
                        StringBuilder constr2 = new StringBuilder(": Los cuentos de los hermanos green marcaron mi infancia");

                        //hacemos uso del WritheLine para mostrar en pantalla lo que hay dentro del constructor
                        Console.WriteLine(constr2);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo AppedFormat para constructores
                    case 24:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio vamos a agregar una serie de palabras con el metodo AppendFormat a nuestro constructor para formar una frase");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //definimos nuestro variables  que vamos a agregar, el constructor y los mostramos por pantalla
                        StringBuilder constructor = new StringBuilder("El pais ");
                        string fr = "cuenta con un fondo de: ${0} {1:c}";
                        double fo = 5000;
                        string fr2 = "Billones de pesos.";

                        Console.WriteLine("El constructor inicial solo contiene la frase: {0}", constructor);
                        Console.WriteLine("\nY Las palabras o variables que vamos a agregar son:\n1) cuenta con un fondo de:\n2) 5000\n3) Billones de pesos.");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodo Apped y mostramos los resultados en pantalla                       
                        constructor.AppendFormat(fr, fo, fr2);
                        Console.WriteLine("El constructor resultante despues de haber agregado las otras palabras o variables es:");
                        Console.WriteLine(constructor);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;





                    //Este ejercicio es con el metodo ToString para constructores
                    case 25:

                        //Explicamos el ejercicio al usuario
                        Console.WriteLine("En este ejercicio convertiremos un constructor que contiene un numero telefonico a un dato de tipo string utilizando el metodo ToString ");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //definimos nuestro constructor y mostramos su contenido en pantalla
                        StringBuilder constr3 = new StringBuilder("3152637584");
                        Console.WriteLine("Este es el numero telefonico que esta dentro del constructor: {0}",constr3);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Utilizamos el metodoToString para convertir el constructor a tipo string y los mostramos en pantalla
                        constr3.ToString();
                        Console.WriteLine("Este es el numero telefonico dentro del constructor que hemos convertido a tipo String: {0}", constr3);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        //Ponemos un Readkey y un clear para que al presionar una tecla la pantalla se liempie y se le vuelva a mostrar el menú al usuario 
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////");
                        break;                    
                }
            } while (op <= 25);
        }
    }
}
