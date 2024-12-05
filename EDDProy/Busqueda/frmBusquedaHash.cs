using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda.Clases;

namespace EDDemo.Busqueda
{
    public partial class frmBusquedaHash : Form
    {
        private BusquedaHash tablaHash;
        public frmBusquedaHash()
        {
            InitializeComponent();
            tablaHash = new BusquedaHash();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarValores()
        {
            StringBuilder valoresTexto = new StringBuilder();

            // Recorremos todas las claves y valores
            for (int i = 0; i < BusquedaHash.TAMANIO; i++)
            {
                if (tablaHash.claves[i] != -1) // Verificamos si la posiicion tiene datos
                {
                    // Agregar la clave y valor al StringBuilder
                    valoresTexto.AppendLine($"clave: {tablaHash.claves[i]}" + $" - Valor: {tablaHash.valores[i]}");
                }
            }

            label4.Text = valoresTexto.ToString();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtClave.Text, out int clave) && !string.IsNullOrEmpty(txtValor.Text))
            {
                tablaHash.Insertar(clave, txtValor.Text);
                MessageBox.Show("Dato insertado correctamente.");
                txtClave.Clear();
                txtValor.Clear();


                ActualizarValores();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una clave válida y un valor.");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int clave))
            {
                string resultado = tablaHash.Buscar(clave); // Buscar en la tabla hash
                labelResultado.Text = resultado != null ? $"Valor encontrado: {resultado}" : "Clave no encontrada.";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una clave valida.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtClave.Clear();
            txtValor.Clear();

            // Limpiar el Label que muestra los valores de la tabla hash
            label4.Text = string.Empty;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
