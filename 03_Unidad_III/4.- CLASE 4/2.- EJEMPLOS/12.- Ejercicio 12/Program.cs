using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbolBinarioOrdenado
{
    public class ArbolBinarioOrdenado
    {
        // Declaración de las variables de la clase "Nodo"

        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        
        // Declaramos a "raiz" como tipo "Nodo"

        Nodo raiz;

        // Definimos el Constructor

        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }

        /*Creamos un nodo y disponemos los punteros izq y der a null, guardamos 
         * la información que llega al método en el nodo. Si el árbol está 
         * vacío, apuntamos raíz al nodo creado; en caso de no estar vacío, dentro 
         * de una estructura repetitiva vamos comparando info con la información del nodo, 
         * si info es mayor a la del nodo descendemos por el subárbol derecho en caso 
         * contrario descendemos por el subárbol izquierdo. Cuando se encuentra un 
         * subárbol vacío insertar el nodo en dicho subárbol. Para esto llevamos un 
         * puntero anterior dentro del while. */

        public void Insertar(int info)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }

        /* Recorrido en pre-orden: Se recorre la raiz, el subárbol izquierdo en pre-orden y
         * se recorre el subárbol derecho en pre-orden */

        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }
        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        /* Recorrido en Entre-orden: se recorre el subárbol izquierdo en entre-orden, luego 
         * se visita la raíz y finalmente se recorrer el subárbol derecho en entre-orden */

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }
        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }

        /* Recorrido Post-orden: se recorre el subárbol izquierdo en post-orden, luego, se
         * recorre el subárbol derecho en post-orden y finalmente, se visita la raíz. */

        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }
        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();
            Console.ReadKey();
        }
    }
}