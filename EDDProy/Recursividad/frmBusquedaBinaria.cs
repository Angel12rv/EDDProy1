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
    public partial class frmBusquedaBinaria : Form
    {
        private int[] _numeros;
        private BusquedaBinaria busquedaBinaria;
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = (int)numericUpDown1.Value;

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad de números debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Random random = new Random();
                int[] numeros = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    numeros[i] = random.Next(1, 101);
                }
                Array.Sort(numeros);

                label4.Text = string.Join(", ", numeros);

                _numeros = numeros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_numeros == null || _numeros.Length == 0)
                {
                    MessageBox.Show("Primero genere la lista de números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int cantidadCortes = 0;

                Stopwatch stopwatch = Stopwatch.StartNew();

                int posicion = BusquedaBinaria.Buscar(_numeros, numero, 0, _numeros.Length - 1, ref cantidadCortes);

                stopwatch.Stop();

                if (posicion != -1)
                {
                    MessageBox.Show("Número encontrado en posición: " + posicion );
                }
                else
                {
                    MessageBox.Show("Número no encontrado");
                }
                label6.Text = $" {cantidadCortes}";
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
