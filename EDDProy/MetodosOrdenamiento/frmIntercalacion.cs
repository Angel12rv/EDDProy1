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
    public partial class frmIntercalacion : Form
    {
        private int[] arreglo1;
        private int[] arreglo2;
        public frmIntercalacion()
        {
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            int cantidad1 = (int)numericUpDown1.Value;
            int cantidad2 = (int)numericUpDown1.Value;

            Random random = new Random();
            arreglo1 = new int[cantidad1];
            arreglo2 = new int[cantidad2];

            for (int i = 0; i < cantidad1; i++)
            {
                arreglo1[i] = random.Next(1, 100);
            }

            for (int j = 0; j < cantidad2; j++)
            {
                arreglo2[j] = random.Next(1, 100);
            }

            Array.Sort(arreglo1);
            Array.Sort(arreglo2);

            label1.Text = $"Arreglo 1: {string.Join(", ", arreglo1)}";
            label2.Text = $"Arreglo 2: {string.Join(", ", arreglo2)}";
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (arreglo1 == null || arreglo2 == null || arreglo1.Length == 0 || arreglo2.Length == 0)
            {
                MessageBox.Show("Deben haber arreglos primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Intercalacion intercalacion = new Intercalacion();
            int[] resultado = intercalacion.Intercalar(arreglo1, arreglo2);

            label4.Text = "";

            label3.Text = "";
            foreach (var paso in intercalacion.Pasos)
            {
                label3.Text += paso + "\n";
            }

            label4.Text = $"Arreglo combinado: {string.Join(", ", resultado)}";
        }

        private void frmIntercalacion_Load(object sender, EventArgs e)
        {

        }
    }
    }
