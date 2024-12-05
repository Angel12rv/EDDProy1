using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.MetodosOrdenamiento.Clases;

namespace EDDemo.MetodosOrdenamiento
{
    public partial class frmQuickSort : Form
    {
        private int[] arreglo;
        public frmQuickSort()
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

            label2.Text = string.Join(", ", arreglo);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            QuickSort quickSort = new QuickSort();
            quickSort.Ordenar(arreglo);

            label3.Text = "";
            foreach (var paso in quickSort.Pasos)
            {
                label3.Text += paso + "\n";
            }
            label4.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }
    }
}
