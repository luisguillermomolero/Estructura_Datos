using System;

namespace AplicacionBase
{
    public class Program
    {

        static void Main(string[] args)
        {

            mostrarMedicion('f');  // Salida: Una letra minúscula: f
            mostrarMedicion('R');  // Salida: Una letra mayúscula: R
            mostrarMedicion('8');  // Salida: Un dígito: 8
            mostrarMedicion(',');  // Salida: carácter no alfanumérico ","

            void mostrarMedicion(char ch)
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine($"Una letra mayúscula: {ch}");
                }
                else if (char.IsLower(ch))
                {
                    Console.WriteLine($"Una letra minúscula: {ch}");
                }
                else if (char.IsDigit(ch))
                {
                    Console.WriteLine($"Un dígito: {ch}");
                }
                else
                {
                    Console.WriteLine($"Carácter no alfanumérico: {ch}");
                }
            }
        }
    }
}