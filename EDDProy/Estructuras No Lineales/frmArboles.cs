using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;
        private ArbolBusqueda arbol;
        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
            arbol = new ArbolBusqueda();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado

            if (miArbol.Buscareldato(int.Parse(txtDato.Text), miArbol.RegresaRaiz()))
                MessageBox.Show("No puedes insertar datos duplicados");
            else
            {
                miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);
                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.Muestra(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                int numero = int.Parse(txtbuscar.Text);


                if (miArbol.Buscareldato(numero, miArbol.RegresaRaiz()))
                    MessageBox.Show("El "+ numero +" esta en el arbol.");
                else
                    MessageBox.Show("El "+ numero + " no esta en el arbol.");
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpodar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("el arbol esta vacio");
                return;
            }

            miArbol.PodarArbol(ref miRaiz);
            miRaiz = null;

            miArbol.strArbol = ""; 
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                int valorAEliminar = int.Parse(txtValor.Text);

                miArbol.EliminarPredecesor(valorAEliminar, ref miRaiz);

                miRaiz = miArbol.RegresaRaiz();

                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
        }

        private void btnSucesor_Click(object sender, EventArgs e)
        {
            int valorAEliminar = int.Parse(txtValor.Text);

            miArbol.EliminarSucesor(valorAEliminar, ref miRaiz);

            miRaiz = miArbol.RegresaRaiz();

            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("Arbol vacio,Altura 0");
                return;
            }

            int altura = miArbol.Altura(miRaiz);
            MessageBox.Show("El arbol tiene una altura: " + altura);
        }

        private void btncontarhojas_Click(object sender, EventArgs e)
        {
            {
                miRaiz = miArbol.RegresaRaiz();

                if (miRaiz == null)
                {
                    MessageBox.Show("El arbol esta vacio");
                    return;
                }

                int numHojas = miArbol.ContarHojas(miRaiz);
                MessageBox.Show("El arbol tiene este numero de hojas: " + numHojas);
            }
        }

        private void btncantidadnodos_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("Arbol Vacio");
                return;
            }
            int numNodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show("Numero de nodos:  " + numNodos);
        }

        private void btnlleno_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("Arbol vacio");
                return;
            }

            if (miArbol.EsLleno(miRaiz))
                MessageBox.Show("Es un arbol lleno");
            else
                MessageBox.Show("No es un arbol lleno");
        }

        private void btnRecorrerNiveles_Click(object sender, EventArgs e)
        {
            arbol.RecorrerPorNiveles(arbol.RegresaRaiz());
            MessageBox.Show("Recorrido por niveles: " + arbol.strRecorrido);
        }

        private void btnEsBinarioCompleto_Click(object sender, EventArgs e)
        {
            bool esCompleto = arbol.EsBinarioCompleto(arbol.RegresaRaiz());
            MessageBox.Show("El árbol es binario completo: " + (esCompleto ? "Sí" : "No"));
        }
    }
}
