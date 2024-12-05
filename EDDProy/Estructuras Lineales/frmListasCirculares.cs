using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmListasCirculares : Form
    {
        private ListasCirculares circular;
        public frmListasCirculares()
        {
            InitializeComponent();
            circular = new ListasCirculares(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circular.Imprimir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circular.Vaciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valorBuscado = int.Parse(textBox1.Text);
            circular.Buscar(valorBuscado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(textBox2.Text);
            int posicion = int.Parse(textBox3.Text);

            circular.Insertar(posicion, dato);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int posicion = int.Parse(textBox4.Text);

            circular.Eliminar(posicion);
        }
    }
}
