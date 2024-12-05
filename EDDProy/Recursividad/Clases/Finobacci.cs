using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    class Finobacci
    {
        public static int CalcularFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            // Llamadas recursivas
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}