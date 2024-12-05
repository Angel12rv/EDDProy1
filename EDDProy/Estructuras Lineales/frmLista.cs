using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmLista : Form
    {
        private Listas listas;
        public frmLista()
        {
            InitializeComponent();
            listas = new Listas(listBox1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listas.Imprimir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listas.Vaciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(textBox3.Text, out dato))
            {
                listas.Buscar(dato);
            }
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor;
            int lugar;

            if (int.TryParse(textBox1.Text, out valor) && int.TryParse(textBox2.Text, out lugar))
            {
                listas.Insertar(lugar, valor);
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pos;
            if (int.TryParse(textBox4.Text, out pos))
            {
                listas.Eliminar(pos);
            }
            textBox1.Text = "";
        }
    }
}
