using System;
using System.Runtime.Intrinsics.X86;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un
            // año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.Los
            //años múltiplos de 100 no son bisiestos,
            //salvo si ellos también son múltiplos de 400.
            //Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Pedirle al usuario un año de inicio
            //y otro de fin y mostrar todos los años bisiestos en ese
            //rango.

            int anioIngesadoInicio;
            Console.WriteLine("Ingrese un anio de inicio: ");
            string anioInicio=Console.ReadLine();
            bool respuesta=int.TryParse(anioInicio, out anioIngesadoInicio);
            
            int anioIngesadoFin;
            Console.WriteLine("Ingrese un anio de fin: ");
            string anioFin = Console.ReadLine();
            bool respuestaFin = int.TryParse(anioFin, out anioIngesadoFin);
            int periodoAnios = anioIngesadoFin - anioIngesadoInicio;


            int[] bisiestos =new int[periodoAnios];
            int j=0;
            for (int i = anioIngesadoInicio; i <= anioIngesadoFin; i++)
            {
                if (i%100==0 && i%400!=0)
                {
                    continue;
                }
                    if (i%4==0)
                    {
                      
                        bisiestos[j]=i;
                     
                    }
                    
                j++;
            }

            for (int h = 0; h < bisiestos.Length; h++)
            {

                if (bisiestos[h] != 0)
                {
                    Console.WriteLine("El anio {0} es bisiesto", bisiestos[h]);
                }
            }


        }

             
        
    }
}
