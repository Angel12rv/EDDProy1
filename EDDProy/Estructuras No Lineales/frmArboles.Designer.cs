﻿
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarPredecesor = new System.Windows.Forms.Button();
            this.btnSucesor = new System.Windows.Forms.Button();
            this.btnRecorrerNiveles = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btncontarhojas = new System.Windows.Forms.Button();
            this.btncantidadnodos = new System.Windows.Forms.Button();
            this.btnEsBinarioCompleto = new System.Windows.Forms.Button();
            this.btnlleno = new System.Windows.Forms.Button();
            this.btnpodar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 19);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(8, 244);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(677, 370);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(583, 14);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(583, 62);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 29);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(138, 104);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 40);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(138, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(234, 146);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(318, 146);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(249, 116);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(238, 84);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(318, 116);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(318, 84);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(517, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(608, 113);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(58, 22);
            this.txtbuscar.TabIndex = 16;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnEliminarPredecesor
            // 
            this.btnEliminarPredecesor.Location = new System.Drawing.Point(226, 19);
            this.btnEliminarPredecesor.Name = "btnEliminarPredecesor";
            this.btnEliminarPredecesor.Size = new System.Drawing.Size(271, 23);
            this.btnEliminarPredecesor.TabIndex = 17;
            this.btnEliminarPredecesor.Text = "Eliminar un nodo del árbol predecesor";
            this.btnEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btnEliminarPredecesor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSucesor
            // 
            this.btnSucesor.Location = new System.Drawing.Point(226, 44);
            this.btnSucesor.Name = "btnSucesor";
            this.btnSucesor.Size = new System.Drawing.Size(271, 23);
            this.btnSucesor.TabIndex = 18;
            this.btnSucesor.Text = " Eliminar un nodo del árbol sucesor";
            this.btnSucesor.UseVisualStyleBackColor = true;
            this.btnSucesor.Click += new System.EventHandler(this.btnSucesor_Click);
            // 
            // btnRecorrerNiveles
            // 
            this.btnRecorrerNiveles.Location = new System.Drawing.Point(517, 161);
            this.btnRecorrerNiveles.Name = "btnRecorrerNiveles";
            this.btnRecorrerNiveles.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrerNiveles.TabIndex = 19;
            this.btnRecorrerNiveles.Text = "Amplitud";
            this.btnRecorrerNiveles.UseVisualStyleBackColor = true;
            this.btnRecorrerNiveles.Click += new System.EventHandler(this.btnRecorrerNiveles_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(598, 161);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(75, 23);
            this.btnAltura.TabIndex = 20;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btncontarhojas
            // 
            this.btncontarhojas.Location = new System.Drawing.Point(517, 190);
            this.btncontarhojas.Name = "btncontarhojas";
            this.btncontarhojas.Size = new System.Drawing.Size(138, 23);
            this.btncontarhojas.TabIndex = 21;
            this.btncontarhojas.Text = "Cantidad hojas";
            this.btncontarhojas.UseVisualStyleBackColor = true;
            this.btncontarhojas.Click += new System.EventHandler(this.btncontarhojas_Click);
            // 
            // btncantidadnodos
            // 
            this.btncantidadnodos.Location = new System.Drawing.Point(517, 216);
            this.btncantidadnodos.Name = "btncantidadnodos";
            this.btncantidadnodos.Size = new System.Drawing.Size(138, 23);
            this.btncantidadnodos.TabIndex = 22;
            this.btncantidadnodos.Text = "Cantidad nodos";
            this.btncantidadnodos.UseVisualStyleBackColor = true;
            this.btncantidadnodos.Click += new System.EventHandler(this.btncantidadnodos_Click);
            // 
            // btnEsBinarioCompleto
            // 
            this.btnEsBinarioCompleto.Location = new System.Drawing.Point(43, 174);
            this.btnEsBinarioCompleto.Name = "btnEsBinarioCompleto";
            this.btnEsBinarioCompleto.Size = new System.Drawing.Size(186, 23);
            this.btnEsBinarioCompleto.TabIndex = 23;
            this.btnEsBinarioCompleto.Text = "Arbol binario completo";
            this.btnEsBinarioCompleto.UseVisualStyleBackColor = true;
            this.btnEsBinarioCompleto.Click += new System.EventHandler(this.btnEsBinarioCompleto_Click);
            // 
            // btnlleno
            // 
            this.btnlleno.Location = new System.Drawing.Point(43, 204);
            this.btnlleno.Name = "btnlleno";
            this.btnlleno.Size = new System.Drawing.Size(186, 23);
            this.btnlleno.TabIndex = 24;
            this.btnlleno.Text = "Arbol binario lleno";
            this.btnlleno.UseVisualStyleBackColor = true;
            this.btnlleno.Click += new System.EventHandler(this.btnlleno_Click);
            // 
            // btnpodar
            // 
            this.btnpodar.Location = new System.Drawing.Point(321, 190);
            this.btnpodar.Name = "btnpodar";
            this.btnpodar.Size = new System.Drawing.Size(75, 23);
            this.btnpodar.TabIndex = 25;
            this.btnpodar.Text = "Podar";
            this.btnpodar.UseVisualStyleBackColor = true;
            this.btnpodar.Click += new System.EventHandler(this.btnpodar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(503, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(72, 22);
            this.txtValor.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Arboles";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnpodar);
            this.Controls.Add(this.btnlleno);
            this.Controls.Add(this.btnEsBinarioCompleto);
            this.Controls.Add(this.btncantidadnodos);
            this.Controls.Add(this.btncontarhojas);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnRecorrerNiveles);
            this.Controls.Add(this.btnSucesor);
            this.Controls.Add(this.btnEliminarPredecesor);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnEliminarPredecesor;
        private System.Windows.Forms.Button btnSucesor;
        private System.Windows.Forms.Button btnRecorrerNiveles;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btncontarhojas;
        private System.Windows.Forms.Button btncantidadnodos;
        private System.Windows.Forms.Button btnEsBinarioCompleto;
        private System.Windows.Forms.Button btnlleno;
        private System.Windows.Forms.Button btnpodar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}