using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.MetodosOrdenamiento
{
    public partial class frmRadix : Form
    {
        private int[] arreglo;
        public frmRadix()
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
                arreglo[i] = random.Next(1, 1000);
            }

            label2.Text = $"{string.Join(", ", arreglo)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero crea el arreglo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Radix radix = new Radix();
            radix.Ordenar(arreglo);

            label3.Text = "";

            foreach (var paso in radix.Pasos)
            {
                label3.Text += paso + "\n";
                label4.Text = "";
                label4.Text += $"Arreglo ordenado: " + paso + "\n";
            }
        }
    }
}
