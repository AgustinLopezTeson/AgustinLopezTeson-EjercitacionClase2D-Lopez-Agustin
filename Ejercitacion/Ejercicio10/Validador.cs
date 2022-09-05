using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Validador
    {


        public static bool ValidarNumerico(int valor,int min,int max)
        {
            if (valor > -100 && valor < 100)
            {
                return true;

            }

            return false;
        }

    }
}
