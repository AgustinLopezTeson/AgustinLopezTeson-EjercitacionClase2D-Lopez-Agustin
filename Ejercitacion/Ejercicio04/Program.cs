using System;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio04
{
    internal class Program
    {
        /*  Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            Escribir una aplicación que encuentre los 4 primeros números perfectos.*/



        static void Main(string[] args)
        {

            int i, j, contador;
            int[] perfectos = new int[4];
            i = 1;
            int n = 0;
            int maximos = 0;

            while (true)//ciclo infinito
            {
                contador = 0;
                i++;

                for (j = 1; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    { contador += j;
                }
                
                if (contador == i)
                {
                    perfectos[n] = i;
                    n++;
                    maximos++;
                }
                
                if (maximos == 4)
                {
                        break; 
                }


            }


            for (int h= 0; h < perfectos.Length; h++)
                {
                    Console.WriteLine(perfectos[h]);
                }
            
        }
    }
   
