﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    class Factorial
    {
       public static long CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;

            return numero * CalcularFactorial(numero - 1);
        }
    }
}