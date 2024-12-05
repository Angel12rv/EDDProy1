using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento.Clases
{
    internal class Shellsort
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public void Ordenar(int[] arreglo)
        {
            Pasos.Clear();

            int n = arreglo.Length;
            int intervalo = n / 2;

            while (intervalo > 0)
            {
                for (int i = intervalo; i < n; i++)
                {
                    int temp = arreglo[i];
                    int j = i;

                    while (j >= intervalo && arreglo[j - intervalo] > temp)
                    {
                        arreglo[j] = arreglo[j - intervalo];
                        j -= intervalo;
                    }

                    arreglo[j] = temp;
                }

                Pasos.Add($"Rango de ({intervalo}): {string.Join(", ", arreglo)}");

                intervalo /= 2;
            }
        }
    }
}