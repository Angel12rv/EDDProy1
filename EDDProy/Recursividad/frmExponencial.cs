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

namespace EDDemo.Recursividad
{
    public partial class frmExponencial : Form
    {
        public frmExponencial()
        {
            InitializeComponent();
        }

        private void Exponencial_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNum = int.Parse(textBox1.Text);
                int exponente = int.Parse(textBox2.Text);


                Stopwatch stopwatch = Stopwatch.StartNew();

                int resultado = Exponencial.CalcularExponente(baseNum, exponente);

                stopwatch.Stop();

                label5.Text = $"{resultado}";
                label7.Text = "";
                label7.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";

            }
            catch (FormatException)
            {
                MessageBox.Show("", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
