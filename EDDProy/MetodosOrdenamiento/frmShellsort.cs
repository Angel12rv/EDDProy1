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
    public partial class frmShellsort : Form
    {
        private int[] arreglo;
        public frmShellsort()
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

            label2.Text = $"Arreglo inicial: {string.Join(", ", arreglo)}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                MessageBox.Show("Primero debes crear un arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia de ShellSort y ordenar
            Shellsort shellSort = new Shellsort();
            shellSort.Ordenar(arreglo);

            // Limpiar el Label de pasos previos
            label3.Text = "";

            // Mostrar los pasos intermedios en el Label
            foreach (var paso in shellSort.Pasos)
            {
                label3.Text += paso + "\n";
            }

            // Mostrar el arreglo final en otro Label
            label4.Text = $"Arreglo ordenado: {string.Join(", ", arreglo)}";
        }
    }
}
