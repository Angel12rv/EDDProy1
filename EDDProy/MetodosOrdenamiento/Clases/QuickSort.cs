using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.MetodosOrdenamiento.Clases
{
    internal class QuickSort
    {
        public List<string> Pasos { get; private set; } = new List<string>();

        public void Ordenar(int[] arreglo)
        {
            Pasos.Clear();
            OrdenarRecursivo(arreglo, 0, arreglo.Length - 1);
        }

        private void OrdenarRecursivo(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indicePivote = Particionar(arreglo, izquierda, derecha);

                Pasos.Add(string.Join(", ", arreglo));

                OrdenarRecursivo(arreglo, izquierda, indicePivote - 1);
                OrdenarRecursivo(arreglo, indicePivote + 1, derecha);
            }
        }

        private int Particionar(int[] arreglo, int izquierda, int derecha)
        {
            int pivote = arreglo[derecha];
            int i = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                if (arreglo[j] <= pivote)
                {
                    i++;
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            int tempPivote = arreglo[i + 1];
            arreglo[i + 1] = arreglo[derecha];
            arreglo[derecha] = tempPivote;

            return i + 1;
        }
    }
}