using System;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombre;
            int antiguedad;
            int cantidadHorasTrabajadas;
            float totalBruto;
            float totalNeto;



            string seguir;
            do
            {

                Console.WriteLine("Ingrese valor hora: ");
                string valorHoraStr = Console.ReadLine();
                bool respuestaValorHora = int.TryParse(valorHoraStr, out valorHora);

                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese antiguedad: ");
                string antiguedadStr = Console.ReadLine();
                bool repuestaAntiguedad = int.TryParse(antiguedadStr, out antiguedad);

                Console.WriteLine("Ingrese horas trabajadas: ");
                string horasTrabajadasStr = Console.ReadLine();
                bool respuestaHorasTrabajadas = int.TryParse(horasTrabajadasStr, out cantidadHorasTrabajadas);


                totalBruto = (valorHora * cantidadHorasTrabajadas) + (antiguedad * 150);
                totalNeto = totalBruto * 0.87f;

                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0} anios", antiguedad);
                Console.WriteLine("Valor hora: ${0}", valorHora);
                Console.WriteLine("Total Bruto: ${0}", totalBruto);
                Console.WriteLine("Total Neto: ${0}", totalNeto);
                Console.WriteLine();
                Console.WriteLine("Quiero seguir (S/N): ");
                seguir = Console.ReadLine();

                Console.Clear();

            } while (seguir == "s");


        }
    }
}
