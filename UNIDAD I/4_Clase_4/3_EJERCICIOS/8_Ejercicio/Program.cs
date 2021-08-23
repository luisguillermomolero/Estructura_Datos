using System;

//Pediremos los IDs (números) de alumnos de dos clases, álgebra y análisis. Queremos
//mostrar todos los alumnos comunes en las dos asignaturas.
namespace AplicacionBase
{
    class Program
    {       
        static void Main(string[] args)
        {
            int alumnosEnDosGrupos = 0;

            Console.Write("Cuantos alumnos se encuentran inscritos en la materia Algebra: ");
            int alumnosAlgebra = int.Parse(System.Console.ReadLine());

            int[] grupoAlgebra = new int[alumnosAlgebra];

            for (int i = 0; i < alumnosAlgebra; i++)
            {
                Console.Write($"Digite el identificador del alumno {i+1}: ");
                grupoAlgebra[i] = int.Parse(System.Console.ReadLine());
            }

            Console.Write("Cuantos alumnos se encuentran inscritos en la materia Analisis: ");
            int alumnosAnalisis = int.Parse(System.Console.ReadLine());

            int[] grupoAnalisis = new int[alumnosAnalisis];
            for (int i = 0; i < alumnosAnalisis; i++)
            {
                Console.Write($"Digite el identificador del alumno {i+1}: ");
                grupoAnalisis[i] = int.Parse(Console.ReadLine());
            }
            
            if (grupoAlgebra.Length < grupoAnalisis.Length){
                
                for(int f = 0 ; f < grupoAlgebra.Length; f++){
                    for(int c = 0 ; c < grupoAnalisis.Length; c++){
                        if (grupoAlgebra[f] == grupoAnalisis[c])
                            alumnosEnDosGrupos += 1;
                    }
                    Console.WriteLine($"El alumno con Id {grupoAlgebra[f]} cursa Algebra y Análisis");
                }
            }else{
                
                for(int f = 0 ; f < grupoAnalisis.Length; f++){
                    for(int c = 0 ; c < grupoAlgebra.Length; c++){
                        if (grupoAnalisis[f] == grupoAlgebra[c])
                            alumnosEnDosGrupos += 1;
                    }
                    Console.WriteLine($"El alumno con Id {grupoAnalisis[f]} cursa Análisis y Algebra");
                }
            }

            Console.WriteLine($"{alumnosEnDosGrupos} alumnos se encuentran inscritos en Algebra y Análisis");
            Console.ReadKey();
        }
    }
}
