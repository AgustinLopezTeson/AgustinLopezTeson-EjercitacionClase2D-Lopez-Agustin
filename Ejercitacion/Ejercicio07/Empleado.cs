using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Empleado
    {

        private int valorHora;
        private string nombre;
        private int antiguedad;
        private int cantidadHorasTrabajadas;
        private float totalBruto;
        private float totalNeto;


        public int getValorHora()
        {
            return valorHora;
        }

        public void setValorHora(int value)
        {
            if (valorHora > 0)
            {
                this.valorHora = value;
            }
        }

        public int Antiguedad
        {
            
            get
            {
                return antiguedad;
            }
            
            set
            {
                this.antiguedad = value;
            }

         }

        public Empleado()
        {
        }
        public Empleado(int valorHora, string nombre, int antiguedad, int cantidadHorasTrabajadas, float totalBruto, float totalNeto)
        {
            this.valorHora = valorHora;
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.cantidadHorasTrabajadas = cantidadHorasTrabajadas;
            this.totalBruto = totalBruto;
            this.totalNeto = totalNeto;
        }
    }
}
