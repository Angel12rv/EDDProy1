using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Recursividad.Clases;

namespace EDDemo.Recursividad
{
    public partial class frmTorresHannoi : Form
    {
        private Torres_Hannoi hanoi = new Torres_Hannoi();
        public frmTorresHannoi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadDiscos = (int)numericUpDown1.Value;

            int movimientos = hanoi.CalcularMovimientos(cantidadDiscos);

            label4.Text = "";
            label4.Text = $"{movimientos}";
            hanoi.Movimientos = string.Empty;

            Torres_Hannoi hannoi = new Torres_Hannoi();

            hanoi.ResolverHanoi(cantidadDiscos, "A", "C", "B");

            label5.Text = "";
            label5.Text = hanoi.Movimientos;

        }
    }
}
