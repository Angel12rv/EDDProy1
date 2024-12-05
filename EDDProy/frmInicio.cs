using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.MetodosOrdenamiento;

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
    }
}
