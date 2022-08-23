using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximoNumeroIngresado=0;
            int minimoNumeroIngresado = 0;
            int promedioDeNumeroIngresados =0;
            int numeroIngresadoInt;
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Ingrese un numero ({0}): ", j+1);
                    string numeroIngresado = Console.ReadLine();
                    bool resultado = int.TryParse(numeroIngresado,out numeroIngresadoInt);

                    while (resultado==false)
                    {
                        Console.WriteLine("Error ingrese un valor correcto: ");
                        numeroIngresado = Console.ReadLine();
                        resultado = int.TryParse(numeroIngresado, out numeroIngresadoInt);
                    }

                    minimoNumeroIngresado = numeroIngresadoInt;
                    maximoNumeroIngresado = Math.Max(maximoNumeroIngresado, numeroIngresadoInt);
                    minimoNumeroIngresado = Math.Min(minimoNumeroIngresado, numeroIngresadoInt);

                    promedioDeNumeroIngresados += numeroIngresadoInt;
                }
                promedioDeNumeroIngresados /= 5;
            
            Console.WriteLine("Maximo: {0}  | Minimo: {1}  | Promedio: {2}",maximoNumeroIngresado,minimoNumeroIngresado,promedioDeNumeroIngresados);


        }
    }
}

