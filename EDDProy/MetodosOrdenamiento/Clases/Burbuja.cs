using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento
{
    internal class Burbuja
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Ordenar(int[] arreglo)
        {
            Pasos.Clear();
            int n = arreglo.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;

                        Pasos.Add($"Paso {Pasos.Count + 1}: {string.Join(", ", arreglo)}");
                    }
                }
            }

            return arreglo;
        }
    }
}