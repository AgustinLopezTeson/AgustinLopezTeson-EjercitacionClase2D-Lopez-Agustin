using System;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            string numeros = Console.ReadLine();
            bool resultado=int.TryParse(numeros, out numero);

             while (resultado == false || numero<0)
             {       
                 Console.WriteLine("Error, Reingrese el numero");
                 numeros = Console.ReadLine();
                 resultado = int.TryParse(numeros, out numero);
             } 

            double cubo=Math.Pow(numero,3);
            double cuadrado=Math.Pow(numero,2);

            Console.WriteLine("Cubo de {0} es: {1}",numero,cubo);
            Console.WriteLine("Cuadrado de {0} es: {1}",numero,cuadrado);

        }
    }
}
