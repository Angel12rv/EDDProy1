using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento.Clases
{
    internal class MezclaDirecta
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Ordenar(int[] arreglo)
        {
            Pasos.Clear();

            int n = arreglo.Length;
            int[] auxiliar = new int[n];

            for (int tamaño = 1; tamaño < n; tamaño *= 2)
            {
                for (int izquierda = 0; izquierda < n; izquierda += 2 * tamaño)
                {
                    int medio = Math.Min(izquierda + tamaño, n);
                    int derecha = Math.Min(izquierda + 2 * tamaño, n);

                    Intercalar(arreglo, auxiliar, izquierda, medio, derecha);
                }

                Pasos.Add($"Con grupos de: {tamaño}: {string.Join(", ", arreglo)}");
            }

            return arreglo;
        }

        private void Intercalar(int[] arreglo, int[] auxiliar, int izquierda, int medio, int derecha)
        {
            int i = izquierda, j = medio, k = izquierda;

            while (i < medio && j < derecha)
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
            while (j < derecha)
            {
                auxiliar[k++] = arreglo[j++];
            }
            for (i = izquierda; i < derecha; i++)
            {
                arreglo[i] = auxiliar[i];
            }
        }
    }
}