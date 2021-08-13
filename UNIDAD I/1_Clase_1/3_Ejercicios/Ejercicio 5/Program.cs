using System;

namespace AplicacionBase
{

    class Program
    {
        //Escribir un algortimo que me permita calcular el peso de una persona en libras y devuelva su peso en kilogramas//
        static void Main(string[] args)
        {
            float lb = 2.20462f;
            float kg = 0.453592f;
            float lbak = 0.0f;
            float kgal = 0.0f;
            float kgr = 0.0f;
            string entrada = "";

            Console.WriteLine("hola, hoy vamos a convertir tu peso de libras a kilogramos");
            Console.WriteLine("");
            Console.WriteLine("por favor, digita tu peso en kilogramos:");
            kgr = float.Parse(System.Console.ReadLine());
            Console.WriteLine("");



            lbak = (kgr * lb) / 1;
            Console.WriteLine("tu peso en kilogramos es:{0} por lo tanto tu peso a libras es:{1}", kgr, lbak);
            Console.WriteLine("");

            kgal = (lbak * kg) / 1;
            Console.WriteLine("tu peso en libras es:{0} por ello tu peso en kilos es:{1}", lbak, kgal);

        }
    }
}