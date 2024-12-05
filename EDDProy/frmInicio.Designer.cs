
using System;
using System.Windows.Forms;

namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeOrdenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burbujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intercalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finobacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torresHannoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.recursividadToolStripMenuItem,
            this.metodosDeOrdenamientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(962, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.dobleToolStripMenuItem,
            this.circularesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // dobleToolStripMenuItem
            // 
            this.dobleToolStripMenuItem.Name = "dobleToolStripMenuItem";
            this.dobleToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.dobleToolStripMenuItem.Text = "Doble";
            this.dobleToolStripMenuItem.Click += new System.EventHandler(this.dobleToolStripMenuItem_Click);
            // 
            // circularesToolStripMenuItem
            // 
            this.circularesToolStripMenuItem.Name = "circularesToolStripMenuItem";
            this.circularesToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.circularesToolStripMenuItem.Text = "Circulares";
            this.circularesToolStripMenuItem.Click += new System.EventHandler(this.circularesToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaBinariaToolStripMenuItem,
            this.exponencialToolStripMenuItem,
            this.factorialToolStripMenuItem,
            this.finobacciToolStripMenuItem,
            this.sumarArregloToolStripMenuItem,
            this.torresHannoiToolStripMenuItem});
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            // 
            // metodosDeOrdenamientoToolStripMenuItem
            // 
            this.metodosDeOrdenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internosToolStripMenuItem,
            this.externosToolStripMenuItem});
            this.metodosDeOrdenamientoToolStripMenuItem.Name = "metodosDeOrdenamientoToolStripMenuItem";
            this.metodosDeOrdenamientoToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.metodosDeOrdenamientoToolStripMenuItem.Text = "Metodos de ordenamiento";
            // 
            // internosToolStripMenuItem
            // 
            this.internosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burbujaToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.radixToolStripMenuItem,
            this.shellSortToolStripMenuItem});
            this.internosToolStripMenuItem.Name = "internosToolStripMenuItem";
            this.internosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.internosToolStripMenuItem.Text = "Internos";
            // 
            // burbujaToolStripMenuItem
            // 
            this.burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            this.burbujaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.burbujaToolStripMenuItem.Text = "Burbuja";
            this.burbujaToolStripMenuItem.Click += new System.EventHandler(this.burbujaToolStripMenuItem_Click);
            // 
            // externosToolStripMenuItem
            // 
            this.externosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intercalacionToolStripMenuItem});
            this.externosToolStripMenuItem.Name = "externosToolStripMenuItem";
            this.externosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.externosToolStripMenuItem.Text = "Externos";
            // 
            // intercalacionToolStripMenuItem
            // 
            this.intercalacionToolStripMenuItem.Name = "intercalacionToolStripMenuItem";
            this.intercalacionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.intercalacionToolStripMenuItem.Text = "Intercalacion";
            this.intercalacionToolStripMenuItem.Click += new System.EventHandler(this.intercalacionToolStripMenuItem_Click_1);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quickSortToolStripMenuItem.Text = "QuickSort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // radixToolStripMenuItem
            // 
            this.radixToolStripMenuItem.Name = "radixToolStripMenuItem";
            this.radixToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.radixToolStripMenuItem.Text = "Radix";
            this.radixToolStripMenuItem.Click += new System.EventHandler(this.radixToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda Binaria";
            // 
            // exponencialToolStripMenuItem
            // 
            this.exponencialToolStripMenuItem.Name = "exponencialToolStripMenuItem";
            this.exponencialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exponencialToolStripMenuItem.Text = "Exponencial";
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.factorialToolStripMenuItem.Text = "Factorial";
            // 
            // finobacciToolStripMenuItem
            // 
            this.finobacciToolStripMenuItem.Name = "finobacciToolStripMenuItem";
            this.finobacciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.finobacciToolStripMenuItem.Text = "Finobacci";
            // 
            // sumarArregloToolStripMenuItem
            // 
            this.sumarArregloToolStripMenuItem.Name = "sumarArregloToolStripMenuItem";
            this.sumarArregloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sumarArregloToolStripMenuItem.Text = "Sumar Arreglo";
            // 
            // torresHannoiToolStripMenuItem
            // 
            this.torresHannoiToolStripMenuItem.Name = "torresHannoiToolStripMenuItem";
            this.torresHannoiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.torresHannoiToolStripMenuItem.Text = "Torres Hannoi";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 517);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Proyecto final";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosDeOrdenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burbujaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externosToolStripMenuItem;
        private ToolStripItem intercalacionToolStripMenuItem1;
        private ToolStripMenuItem intercalacionToolStripMenuItem;
        private ToolStripMenuItem quickSortToolStripMenuItem;
        private ToolStripMenuItem radixToolStripMenuItem;
        private ToolStripMenuItem shellSortToolStripMenuItem;
        private ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private ToolStripMenuItem exponencialToolStripMenuItem;
        private ToolStripMenuItem factorialToolStripMenuItem;
        private ToolStripMenuItem finobacciToolStripMenuItem;
        private ToolStripMenuItem sumarArregloToolStripMenuItem;
        private ToolStripMenuItem torresHannoiToolStripMenuItem;
    }
}

