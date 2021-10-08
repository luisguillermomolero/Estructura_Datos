using System;
using System.Text;

namespace Ejercicios_del_13_al_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 13");
            Console.WriteLine("metodo PadRight()");
            Console.WriteLine();
            //Metodo PadRight()
            //Este metodo lo que nos va hacer es que va a el caracter que queramos y agregarlo al final del String 
            //En este caso agregaremos un * (asterisco), ya que nuestra escritura va de izquierda a decha solo
            //Rellenara los espacios en esa direcion y con la condicions de que solo lo hara al final del string.

            string A = "Si guenas";
            char B = '>';

            //Si el numero que ponemos en ele metodo es amyor al numero de letrs que tiene se agregaran los caracteres hasta completar el nuemero
            //Esta palabra tiene 8 letras asiq ue rellenara de * hasta completar 16
            Console.WriteLine(A.PadRight(16, B));

            //si el numero es mayo o igual al numero de letras, no se agregara nada que que todos los puestos estaran ocupados
            Console.WriteLine(A.PadRight(8, B));

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Ejercicio 14");
            Console.WriteLine("metodo Remove()");
            Console.WriteLine();
            //Lo que hace el metodo Remove() es qu me va a eliminar y/o remover los valores que nosotros le digamos.  

            string Val = "7654---3210";
            //Aquí asignamos en string para mas adelnate decirle cuales valores eliminara de este string.

            Console.WriteLine("1) {0}", Val);
            Console.WriteLine("asignacions de todos los valores en numeros el 0 = 7 y el 10 = 0: 0-1-2-3-4-5-6-7-8-9-10");
            //Mostramos por pantalla el string y le esplicamos al usuario que numero tiene cada valor en el string.
            Console.WriteLine();
            Console.WriteLine("2) {0}", Val.Remove(4, 3));
            //Al decirle que remueva (4, 3) le decimos que coja desde el valor #4 y que quite todo tes espacios empezando desde el.
            Console.WriteLine();
            Console.WriteLine("3) {0}", Val.Remove(4));
            //y al decirle solamente (4) lo que hara es que va a quitar desde el valor 4 en adelante
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Ejercicio 15");
            Console.WriteLine("metodo Remplace()");
            Console.WriteLine();
            //Este metodo como su nombre lo dice nos va a remplazar caulquiera de los valores que estan en el string por otra letra
            //Como dato curiso si le decimos que remplaje solo una letra de una palabra, solo va a cambiar esa del lestra e ignorara al resto


            String Cam = "AAAP";
            Console.WriteLine("Palabra inicial: '{0}'", Cam);
            Cam = Cam.Replace("A", "Z").Replace("Z", "O").Replace("O", "V");
            //Como lo podemos ver aqui, le estamos pidiendo que cambie la letra AAA por Z y luego que la vuelva a cambiar por O
            //Y para finalizar que lo cambie una ultima ves por una V así que inicia mente veremos AAA y finalizaremos con un ZZZ
            Console.WriteLine("Palabra final: '{0}'", Cam);
            //Aqui mostramos por pantalla el resultado final, Cabe aclarar que solo cambiara el numero de veces que este la letra
            //En este caso solo tenemos 3 A asi que solo puede cambiar esas 3 no agregara ni eliminara ninguna y si agregamos otra letra
            //Dejara esa letra hasta el final ya que no le estamos pidiendo que cambie

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Ejercicio 16");
            Console.WriteLine("metodo Split()");
            Console.WriteLine();
            //Lo que hace el metodo Split() es que nos va a quitar lo que le pidamos y dividir el estring que tengamos por el numero de veces que este lo que le hayapos pedido quitar
            //Esta ves le pedi que quitara el "->" asi que cada ves que lo quite hara un salto de linea dividiendo el String

            string Ca = "77->si->33->Buenas->88->tardes";
            string[] ar = Ca.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //Lo que hace esto "StringSplitOptions.RemoveEmptyEntries" es que me va a remover todos los espacios que queden en el string
            //Si no ponemos esto tras cada salto de linea nos va a dejar un espacio en blanco
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
                //Aqui hara uin salto de linea cada ves que se lo diga el arreglo
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Ejercicio 17 y 18");
            Console.WriteLine("metodo ToLower() y ToUpper()");
            Console.WriteLine();
            //Este metodo lo que hace es que nos cambia de mayusculas a minusculas o viceversa, en este ejercicio demostraremos como realizarlo
            //Con una frace en la que las letras esten vareadas entre mayusculas y minusculas y así pedirle que las cambie a una de estas dos solamente
            //Si la letra ya esta en mayuscula simplemente pasara a la siguinte y la cambiara


            string a = "HoLa CoMo eStAs";
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(a.ToLower());
            //Este nos cambia las palabras a Minusculas
            Console.WriteLine();
            Console.WriteLine(a.ToUpper());
            //Este nos la cambiara a mayusculas
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Ejercicio 19, 20 y 21");
            Console.WriteLine("metodo Trim(), TrimStart(), TrimEnd()");
            Console.WriteLine();
            //Este nos metodo nos va a "Podar" los caracteres que nosotros le pídamos, a diferencia del Ejercciio 13,
            //este lo realizara de una manera mas eficiente y precisa
            //Con los metodos TrimStart(), TrimEnd() podremos elegir si queremos quitar los espacios del onicio o del final

            string En = "         *Subeme la nota, por favor.-                ";
            string Re = " Gracias por su coprencion";
            Console.WriteLine(En + Re);
            Console.WriteLine();
            Console.WriteLine(En.Trim() + Re);
            Console.WriteLine();
            Console.WriteLine(En.TrimStart() + Re);
            Console.WriteLine();
            Console.WriteLine(En.TrimEnd() + Re);
            Console.WriteLine();

            //Esta es otra forma de hacerlo para quitar cosas especificas de la oracion
            char[] charsToTrim = { '*', '-', ' ' };
            //Para creamos un arreglo tipos caracter para asi seleccionar a todos los caracteres que queramos quitar del ejercicio
            string Za = En.Trim(charsToTrim);
            Console.WriteLine("Inicia   \n{0}" + Re + " \nTermina   \n{1}" + Re, En, Za);
            //Y aquí mostraremos la diferencia entre el incio y despues de haberle quitado los caracteres

            string[] W = En.Split();
            foreach (string Ws in W)
                Console.WriteLine(Ws.TrimEnd(charsToTrim));
            //Con esta convinacion podremos junstar dos el cual es la divicion y el TirmEnd haciendo que quite los espacios y que me divida cada palabra.

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Ejercicio 22, 23 y 24");
            Console.WriteLine("metodo Append(), WriteLine() y AppendFormat()");
            Console.WriteLine();
            //el metodo append lo que nos hace es que nos va a dicionar lo que queramos a la frace, esto nos facilita el trabajo de no tener que 
            //Agregar linea por linea lo que quieremos al string sino que nos lo permie agregarlo de una
            //Por lo que entendi del WriteLine() es la funcion que ya usamos de por si en este ejercicio para mostrar por pantalla los StringBuilder designados que tenemos 

            StringBuilder sb = new StringBuilder("");
            sb.Append("Si ").Append("Buenas ").Append("Noches");
            Console.Write(sb);
            Console.WriteLine();
            //en el primer ejercciio hago que me agrege tres palabras al espacio vacio que hay en el StringBuilder

            StringBuilder sbr = new StringBuilder("");
            for (int c = 0; c < 10; c++)
            {
                sbr.Append(c).Append(" , ");
            }
            Console.WriteLine(sbr);
            //Y en este hago que cambie ese vacio por los numeros del 0 al 9
            //Mostrado asi dos formas de usar este Metodo

            int ABD = 30;
            StringBuilder DD = new StringBuilder("El precio es ");
            DD.AppendFormat("{0:C}", ABD);
            Console.WriteLine(DD);
            //Este metodo como el anterior agrega algo a lo ue queramos, este agregara un formato al int que tenemos señalizado, agregara un formato 
            //de peso haciendo que se vea un $30.00 para hacer la referencia del precio

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Ejercicio 25");
            Console.WriteLine("metodo ToString()");
            Console.WriteLine();
            //método se utiliza para convertir el valor de esta instancia en una cadena. 
            //Se crea e inicializa un nuevo objeto String para obtener la secuencia de caracteres de este objeto StringBuilder y luego ToString () devuelve String.
            //En este ejercico final aplicaremos otros metodos para complementar el ToString().
            StringBuilder sbx = new StringBuilder("ABC", 50);
            sbx.Append(new char[] { '1', '2', '3' });
            sbx.AppendFormat("456{0}{1}", '7', '8');
            Console.WriteLine("{0} chars: {1}", sbx.Length, sbx.ToString());
            sbx.Insert(0, "Numeros: ");
            sbx.Replace('8', '0');
            Console.WriteLine("{0} chars: {1}", sbx.Length, sbx.ToString());
        }
    }
}