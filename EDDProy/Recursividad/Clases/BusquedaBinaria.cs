using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class BusquedaBinaria
    {
        public static int Buscar(int[] arreglo, int numero, int inicio, int fin, ref int cantidadCortes)
        {
            cantidadCortes++;

            if (inicio > fin)
            {
                return -1;
            }

            int medio = (inicio + fin) / 2;

            if (arreglo[medio] == numero)
            {
                return medio;
            }

            if (numero < arreglo[medio])
            {
                return Buscar(arreglo, numero, inicio, medio - 1, ref cantidadCortes);
            }

            return Buscar(arreglo, numero, medio + 1, fin, ref cantidadCortes);
        }
    }
}