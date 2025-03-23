using System;

namespace PracticaRepaso
{
    internal class PesoADolar
    {
        public static void Ejecutar()
        {

            Console.WriteLine("Ingrese la longitud en centimetros:");
            double peso = float.Parse(Console.ReadLine());
            double dolares = 0.0009;
            double convertido = peso * dolares;
            Console.WriteLine($"{peso} es  = {convertido} in");
        }
    }
}

