using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento.Clases
{
    internal class Intercalacion
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public int[] Intercalar(int[] arreglo1, int[] arreglo2)
        {
            Pasos.Clear();

            int n1 = arreglo1.Length, n2 = arreglo2.Length;
            int[] resultado = new int[n1 + n2];

            int i = 0, j = 0, k = 0;

            while (i < n1 && j < n2)
            {
                if (arreglo1[i] <= arreglo2[j])
                {
                    resultado[k++] = arreglo1[i++];
                }
                else
                {
                    resultado[k++] = arreglo2[j++];
                }

                Pasos.Add($"Intercalando: {string.Join(", ", arreglo1)} y {string.Join(", ", arreglo2)} -> {string.Join(", ", resultado)}");
            }

            while (i < n1)
            {
                resultado[k++] = arreglo1[i++];
                Pasos.Add($"Agregando restante de arreglo1: {string.Join(", ", resultado)}");
            }

            while (j < n2)
            {
                resultado[k++] = arreglo2[j++];
                Pasos.Add($"Agregando restante de arreglo2: {string.Join(", ", resultado)}");
            }

            return resultado;
        }
    }
}