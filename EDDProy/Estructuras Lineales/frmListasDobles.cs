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
    public partial class frmListasDobles : Form
    {
        private ListasDobles listasdobles;
        public frmListasDobles()
        {
            InitializeComponent();
            listasdobles = new ListasDobles(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listasdobles.Imprimir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listasdobles.Vaciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int datoBuscado;
                if (int.TryParse(textBox1.Text, out datoBuscado))
                {
                    listasdobles.Buscar(datoBuscado);
                }
                else
                {
                    MessageBox.Show("Ingresa un valor valido");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor;
            int posicion;

            if (int.TryParse(textBox2.Text, out valor) && int.TryParse(textBox3.Text, out posicion))
            {
                listasdobles.Insertar(posicion, valor);
            }

            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int posicion;
            if (int.TryParse(textBox1.Text, out posicion))
            {
                listasdobles.Eliminar(posicion);
            }
            else
            {
                MessageBox.Show("ingresa una posicion que sea valida");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmListasDobles_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
