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
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmcola : Form
    {
        private Cola cola;
        public frmcola()
        {
            InitializeComponent();
            cola = new Cola(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cola.DeQueue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cola.Imprimir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cola.VaciarCola();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion;
            if (int.TryParse(textBox2.Text, out posicion))
            {
                cola.Recorrer(posicion);
            }
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int DATO;
            if (int.TryParse(textBox1.Text, out DATO))
            {
                NodoBinario nuevoNodo = new NodoBinario(DATO);
                cola.Queue(nuevoNodo);
            }
            textBox1.Text = "";
        }
    }
}
