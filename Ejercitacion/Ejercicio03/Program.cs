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

            for (int i = 1; i <= numeroInt; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if(i%j==0 || i==2)
                    {
                        Console.WriteLine("El numero {0} es primo",i);
                        break;
                    }
                }
            }

        }
    }
}
