using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento.Clases
{
    internal class MezclaNatural
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Ordenar(int[] arreglo)
        {
            Pasos.Clear();
            int n = arreglo.Length;

            int[] auxiliar = new int[n];

            while (true)
            {
                List<int> inicioSubarreglos = new List<int>();

                for (int i = 0; i < n - 1; i++)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        inicioSubarreglos.Add(i + 1);
                    }
                }
                inicioSubarreglos.Add(n); 

                if (inicioSubarreglos.Count == 1)
                    break;

                for (int i = 0; i < inicioSubarreglos.Count - 1; i += 2)
                {
                    int inicio1 = (i == 0) ? 0 : inicioSubarreglos[i - 1];
                    int final1 = inicioSubarreglos[i];
                    int final2 = inicioSubarreglos[i + 1];

                    Intercalar(arreglo, auxiliar, inicio1, final1, final2);
                }

                Pasos.Add($"Después de una iteración: {string.Join(", ", arreglo)}");
            }

            return arreglo;
        }

        private void Intercalar(int[] arreglo, int[] auxiliar, int inicio, int medio, int fin)
        {
            int i = inicio, j = medio, k = inicio;

            while (i < medio && j < fin)
            {
                if (arreglo[i] <= arreglo[j])
                {
                    auxiliar[k++] = arreglo[i++];
                }
                else
                {
                    auxiliar[k++] = arreglo[j++];
                }
            }

            while (i < medio)
            {
                auxiliar[k++] = arreglo[i++];
            }

            while (j < fin)
            {
                auxiliar[k++] = arreglo[j++];
            }

            for (i = inicio; i < fin; i++)
            {
                arreglo[i] = auxiliar[i];
            }
        }
    }
}