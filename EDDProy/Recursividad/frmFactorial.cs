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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Recursividad.Clases
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int numero) && numero >= 0)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                long resultado = Factorial.CalcularFactorial(numero);

                stopwatch.Stop();

                label5.Text = "";
                label5.Text = $" {resultado}";
                label7.Text = "";
                label7.Text = $"{stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }
    }
}
