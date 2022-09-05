using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int maximo=int.MaxValue;
            int minimo=int.MinValue;
            int promedio=0;
            bool respuestaNumero;
            int flagMaximo=0;
            Console.WriteLine("Ingrese 10 numeros:");

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    string numeroIngresadoStr = Console.ReadLine();
                    respuestaNumero = int.TryParse(numeroIngresadoStr, out numeroIngresado);

                } while (Validador.ValidarNumerico(numeroIngresado,-100,100)==false);

                

                    if (flagMaximo==0)
                    {
                        maximo = numeroIngresado;
                        minimo = numeroIngresado;
                        flagMaximo = 1;
                    }

                    if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }

                    if(numeroIngresado<minimo)
                    {
                        minimo = numeroIngresado;
                    }

                    promedio += numeroIngresado;


            }

            Console.WriteLine("Promedio:{0}", promedio / 10);
            Console.WriteLine("Maximo:{0}", maximo);
            Console.WriteLine("Minimo:{0}",minimo);

        }
    }
}
