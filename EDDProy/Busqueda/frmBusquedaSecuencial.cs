using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda.Clases;

namespace EDDemo.Busqueda
{
    public partial class frmBusquedaSecuencial : Form
    {
        private int[] arreglo;
        public frmBusquedaSecuencial()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            int cantidad = (int)numericUpDown1.Value;
            Random random = new Random();
            arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = random.Next(1, 100);
            }

            label6.Text = $"Arreglo: {string.Join(", ", arreglo)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
               if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes crear un arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int valorBuscado))
            {
                MessageBox.Show("Introduce un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BusquedaSecuencial busqueda = new BusquedaSecuencial();
            int posicion = busqueda.Buscar(arreglo, valorBuscado);
            label3.Text = "";
            foreach (var paso in busqueda.Pasos)
            {
                label3.Text += paso + "\n";
            }
            if (posicion >= 0)
            {
                label4.Text = $"Valor encontrado en la posición {posicion}";
            }
            else
            {
                label4.Text = "Valor no encontrado en el arreglo";
            }
        }
    }
}
