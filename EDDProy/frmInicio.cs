using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Busqueda;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.MetodosOrdenamiento;
using EDDemo.Recursividad;
using EDDemo.Recursividad.Clases;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcola mcola = new frmcola();
            mcola.MdiParent = this;
            mcola.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista frmLista = new frmLista();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles frmlista = new frmListasDobles();
            frmlista.MdiParent = this;
            frmlista.Show();
        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCirculares frmlista = new frmListasCirculares();
            frmlista.MdiParent = this;
            frmlista.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja frmburbuja = new frmBurbuja();
            frmburbuja.MdiParent = this;
            frmburbuja.Show();
        }

        private void intercalacionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmIntercalacion frmintercalacion = new frmIntercalacion();
            frmintercalacion.MdiParent = this;
            frmintercalacion.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort frmquicksort = new frmQuickSort();
            frmquicksort.MdiParent = this;
            frmquicksort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix frmradix = new frmRadix();
            frmradix.MdiParent = this;
            frmradix.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellsort frmShellsort = new frmShellsort();
            frmShellsort.MdiParent = this;
            frmShellsort.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria frmBusqueda = new frmBusquedaBinaria();
            frmBusqueda .MdiParent = this;
            frmBusqueda .Show();
        }

        private void exponencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExponencial frmexponencial = new frmExponencial();
            frmexponencial.MdiParent = this;   
            frmexponencial.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial frmfactorial = new frmFactorial();
            frmfactorial.MdiParent = this;
            frmfactorial.Show();
        }

        private void finobacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinobacci frmfinobacci=new frmFinobacci();
            frmfinobacci.MdiParent = this;
            frmfinobacci.Show();
        }

        private void sumarArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArreglo  frmArreglo = new frmArreglo();
            frmArreglo.MdiParent = this;
            frmArreglo.Show();
        }

        private void torresHannoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorresHannoi frmTorres=new frmTorresHannoi();
            frmTorres.MdiParent = this;
            frmTorres.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaNatural frmMezclaNatural = new frmMezclaNatural();
            frmMezclaNatural.MdiParent = this;
            frmMezclaNatural.Show();
        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMezclaDirecta frmMezclaDirecta = new frmMezclaDirecta();
            frmMezclaDirecta.MdiParent = this;
            frmMezclaDirecta.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaHash frmBusquedaHash = new frmBusquedaHash();
            frmBusquedaHash.MdiParent = this;
            frmBusquedaHash.Show();
        }
    }
}