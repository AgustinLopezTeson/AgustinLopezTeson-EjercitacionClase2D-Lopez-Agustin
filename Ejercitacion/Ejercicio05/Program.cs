using System;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero;
            string numeroIngresado=Console.ReadLine();
            bool respuesta = int.TryParse(numeroIngresado, out numero);
            int centro;
            int flagPrimeraEntrada = 0;
            for (centro = 1; centro < numero; centro++)
            {

                int sumaPrimeros = 0;
                
                for (int i = 1; i < centro/2; i++)
                {
                    sumaPrimeros = sumaPrimeros + i;
                    flagPrimeraEntrada++;
                }

                int sumaUltimos = 0;

                for (int j = centro/2; j<=centro; j++)
                {
                    sumaUltimos=  sumaUltimos+ j;
                    flagPrimeraEntrada++;
                }

                if (flagPrimeraEntrada!=0)
                {
                    if (sumaPrimeros == sumaUltimos)
                    {
                        break;
                    }

                }



            }


            Console.WriteLine("El centro es {0}",centro);



        }
    }
}
