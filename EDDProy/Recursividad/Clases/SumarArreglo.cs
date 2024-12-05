using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class SumarArreglo
    {
        private static Random random = new Random();
        public static int[] GenerarArreglo(int tamaño, int min = 0, int max = 100, int[] arreglo = null, int index = 0)
        {
            if (arreglo == null)
            {
                arreglo = new int[tamaño];
            }

            if (index >= tamaño)
            {
                return arreglo;
            }

            arreglo[index] = random.Next(min, max);
            return GenerarArreglo(tamaño, min, max, arreglo, index + 1);
        }
        public static int CalcularSuma(int[] arreglo, int index = 0)
        {
            if (index >= arreglo.Length)
            {
                return 0;
            }

            return arreglo[index] + CalcularSuma(arreglo, index + 1);
        }
    }
}