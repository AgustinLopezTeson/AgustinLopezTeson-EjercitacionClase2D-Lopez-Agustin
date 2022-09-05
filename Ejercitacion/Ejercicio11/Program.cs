using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string numeroIngresadoStr;
            bool respuestaNumeroIngresado;
            string respuesta = "s";
            int suma=0;
            
            do
            {
                Console.WriteLine("Ingrese numero para sumar:");
                numeroIngresadoStr =Console.ReadLine();
                respuestaNumeroIngresado=int.TryParse(numeroIngresadoStr, out numeroIngresado);
                suma += numeroIngresado;
                Console.WriteLine("¿Desea continuar? (S/N)");
                respuesta = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("La suma de los numeros ingresados es {0}",suma);
        }
    }
}
