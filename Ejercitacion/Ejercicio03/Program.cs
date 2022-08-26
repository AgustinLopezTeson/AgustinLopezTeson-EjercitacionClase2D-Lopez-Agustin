using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            Console.WriteLine("Para terminar ingrese SALIR");

            string opcionIngresada = Console.ReadLine();

            if (opcionIngresada == "salir")
                {
                    Environment.Exit(0);
                }

            bool respuesta = int.TryParse(opcionIngresada, out int numeroInt);


            while (respuesta == false)
            {
                   Console.WriteLine("Error,ingrese un dato valido");
                   Console.WriteLine("Para terminar ingrese SALIR");

                   if(opcionIngresada=="salir")
                   {
                       Environment.Exit(0);
                   }
            }


            for (int x = 0; x <= numeroInt; x++)
            {
                if (EsPrimo(x))
                {
                    Console.WriteLine(x);
                }
            }

        }

        static bool EsPrimo(int num)
        {

            bool respuesta=true;

            for (int i = 2; i <= num / 2; i++)
            {

                if (num % i == 0)
                {

                    respuesta = false;
                }
                else
                {
                    if (i == 2 || i == 4)
                    {
                        respuesta = true;
                    }

                }


            }
            return respuesta;
        }

    }
}
