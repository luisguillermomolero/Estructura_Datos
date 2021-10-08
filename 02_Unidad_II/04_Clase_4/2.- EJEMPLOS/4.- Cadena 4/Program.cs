using System;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de TrimStart

            string lineWithLeadingSpaces = "    Hello World!";
            string lineWithLeadingSymbols = "$$$$Hello World!";
            string lineWithLeadingUnderscores = "_____Hello World!";
            string lineWithLeadingLetters = "xxxxHello World!";
            string lineAfterTrimStart = string.Empty;

            // Facilite la impresión y el trabajo con todos los ejemplos

            string[] lines = { lineWithLeadingSpaces, lineWithLeadingSymbols, lineWithLeadingUnderscores, lineWithLeadingLetters };

            foreach (var line in lines)
            {
                Console.WriteLine($"Esta línea tiene caracteres basura al inicio: {line}");
            }

            lineAfterTrimStart = lineWithLeadingUnderscores.TrimStart('_');

            Console.WriteLine("");
            Console.WriteLine($"Este es el resultado luego de retirar los caracteres basura a {lineAfterTrimStart}");

            foreach (var lineToEdit in lines)
            {
                Console.WriteLine(lineToEdit.TrimStart(' ', '$', '_', 'x'));
            }
        }
    }
}
