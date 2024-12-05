using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento
{
    internal class Radix
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public void Ordenar(int[] arreglo)
        {
            Pasos.Clear();

            int max = ObtenerMaximo(arreglo);
            int exp = 1;

            while (max / exp > 0)
            {
                arreglo = ContarPorDigitos(arreglo, exp);
                Pasos.Add($"Dígito {exp}: {string.Join(", ", arreglo)}");

                exp *= 10;
            }
        }

        private int ObtenerMaximo(int[] arreglo)
        {
            int max = arreglo[0];
            foreach (int num in arreglo)
            {
                if (num > max) max = num;
            }
            return max;
        }

        private int[] ContarPorDigitos(int[] arreglo, int exp)
        {
            int n = arreglo.Length;
            int[] salida = new int[n];
            int[] conteo = new int[10];
            for (int i = 0; i < n; i++)
            {
                int digito = (arreglo[i] / exp) % 10;
                conteo[digito]++;
            }
            for (int i = 1; i < 10; i++)
            {
                conteo[i] += conteo[i - 1];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                int digito = (arreglo[i] / exp) % 10;
                salida[conteo[digito] - 1] = arreglo[i];
                conteo[digito]--;
            }

            return salida;
        }
    }
}