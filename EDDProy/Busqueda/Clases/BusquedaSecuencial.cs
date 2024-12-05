using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Busqueda.Clases
{
         class BusquedaSecuencial
    {

        public List<string> Pasos { get; private set; } = new List<string>();

        public int Buscar(int[] arreglo, int valorBuscado)
        {
            Pasos.Clear();

            for (int i = 0; i < arreglo.Length; i++)
            {
                Pasos.Add($"Paso {i + 1}: Comparando {arreglo[i]} con {valorBuscado}");

                if (arreglo[i] == valorBuscado)
                {
                    Pasos.Add($"Valor encontrado en la posición {i}");
                    return i;
                }
            }

            Pasos.Add("Valor no encontrado");
            return -1;
        }
    }
}