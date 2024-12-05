using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad.Clases
{
    internal class Torres_Hannoi
    {
        public string Movimientos { get; set; }

        public Torres_Hannoi()
        {
            Movimientos = string.Empty;
        }

        public int CalcularMovimientos(int discos)
        {
            if (discos == 1)
            {
                return 1;
            }

            else if (discos == 0)
            {
                MessageBox.Show("Agrega algún disco");
                return 0;

            }
            else
            {
                return 2 * CalcularMovimientos(discos - 1) + 1;
            }
        }

        public void ResolverHanoi(int discos, string origen, string destino, string auxiliar)
        {
            if (discos == 1)
            {
                Movimientos += $"Mover disco de {origen} a {destino}\n";
            }

            if (discos == 0)
            {

            }
            else
            {
                ResolverHanoi(discos - 1, origen, auxiliar, destino);
                Movimientos += $"Mover disco de {origen} a {destino}\n";
                ResolverHanoi(discos - 1, auxiliar, destino, origen);
            }
        }
    }
}