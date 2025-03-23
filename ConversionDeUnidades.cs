using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRepaso
{
    internal class ConversionDeUnidades
    {
        public static void Ejecutar()
        {
            
            Console.WriteLine("Ingrese la longitud en centimetros:");
            float cm = float.Parse(Console.ReadLine());
            float pulgadas = cm / 2.54f;
            Console.WriteLine($"{cm} / cm = {pulgadas:f4} in");
        }
    }
}
