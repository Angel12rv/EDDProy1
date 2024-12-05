using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Recursividad.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Recursividad
{
    public partial class frmFinobacci : Form
    {
        public frmFinobacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = int.Parse(textBox2.Text);

                if (posicion < 0)
                {
                    MessageBox.Show("Por favor introduce una posicion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Stopwatch stopwatch = Stopwatch.StartNew();

                int resultado = Finobacci.CalcularFibonacci(posicion);

                stopwatch.Stop();

                label5.Text = $"{resultado}";
                label7.Text = "";
                label7.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
