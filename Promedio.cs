using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRepaso
{
    internal class Promedio
    {
        public static void Ejecutar()
        {
           
            int cantidadDeNotas = 4;
            int sumadorDeNotas = 0;

            for (int i = 0; i <= cantidadDeNotas; i++)
            {
                Console.Write($"Ingrese Nota {i}:");
                int nota = int.Parse(Console.ReadLine());
                sumadorDeNotas += nota;

            }
            float promedio = (float)sumadorDeNotas / cantidadDeNotas;
            Console.WriteLine($"El promedio es {promedio}:");

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
