using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Recursividad.Clases;

namespace EDDemo.Recursividad
{
    public partial class frmArreglo : Form
    {
        public frmArreglo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tamaño = (int)numericUpDown1.Value;

                if (tamaño <= 0)
                {
                    MessageBox.Show("El tamaño del arreglo debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] arreglo = SumarArreglo.GenerarArreglo(tamaño);

                Stopwatch stopwatch = Stopwatch.StartNew();

                int suma = SumarArreglo.CalcularSuma(arreglo);

                stopwatch.Stop();

                string numerosFormateados = string.Join(" ", arreglo.Select(num => $"[{num}]"));

                label4.Text = numerosFormateados;

                label6.Text = suma.ToString();

                label8.Text = "";
                label8.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
