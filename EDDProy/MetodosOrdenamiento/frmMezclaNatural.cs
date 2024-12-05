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
    public partial class frmMezclaNatural : Form
    {
        private int[] arreglo;
        public frmMezclaNatural()
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

            label2.Text = $"Arreglo original: {string.Join(", ", arreglo)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes crear un arreglo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MezclaNatural mezclaNatural = new MezclaNatural();
            mezclaNatural.Ordenar(arreglo);

            label3.Text = "";

            foreach (var paso in mezclaNatural.Pasos)
            {
                label3.Text += paso + "\n";
            }

            label4.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
