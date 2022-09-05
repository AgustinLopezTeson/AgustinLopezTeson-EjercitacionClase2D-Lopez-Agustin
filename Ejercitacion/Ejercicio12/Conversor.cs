using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numero) {

            string binario="";
            int resto;
            const int divisor = 2;

            while (numero>0)
            {
                resto = numero % divisor;
                
                numero /= divisor;
                
                binario=resto.ToString()+binario;

            }
            return binario;

        }

        public static int ConvertirBinarioADecimal(int binario) {

            int num = binario;
            int numeroDecimal=0;
            int multiplicador = 1;
            int digito;

            int temp = num;
           
            while (temp>0)
            {
                digito = temp % 10;
                temp /= 10;
                
                numeroDecimal += digito*multiplicador;
                
                multiplicador *=2;
            }


            return numeroDecimal;
        }
    }
}
