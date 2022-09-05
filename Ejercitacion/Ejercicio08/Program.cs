using System;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int altura;
            Console.WriteLine("Ingrese la altura del triangulo:");
            string alturaStr = Console.ReadLine();
            bool respuestaAltura = int.TryParse(alturaStr, out altura);
            int contador=1;
            Console.WriteLine();

            Console.Clear();
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < contador; j++)
                {
                    Console.Write("*");
                }
                contador += 2;
                Console.WriteLine();
            }

        }
    }
}
