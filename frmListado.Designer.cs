﻿namespace PryTPCalvet
{
    partial class frmListado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabApellido = new System.Windows.Forms.TabPage();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tabDireccion = new System.Windows.Forms.TabPage();
            this.cmdListarBarrio = new System.Windows.Forms.Button();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabApellido.SuspendLayout();
            this.tabDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabApellido);
            this.tabControl1.Controls.Add(this.tabDireccion);
            this.tabControl1.Location = new System.Drawing.Point(18, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabApellido
            // 
            this.tabApellido.Controls.Add(this.txtApellido);
            this.tabApellido.Controls.Add(this.cmdListar);
            this.tabApellido.Controls.Add(this.lblApellido);
            this.tabApellido.Location = new System.Drawing.Point(4, 22);
            this.tabApellido.Name = "tabApellido";
            this.tabApellido.Padding = new System.Windows.Forms.Padding(3);
            this.tabApellido.Size = new System.Drawing.Size(450, 74);
            this.tabApellido.TabIndex = 0;
            this.tabApellido.Text = "Apellido";
            this.tabApellido.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(222, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(369, 48);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(128, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // tabDireccion
            // 
            this.tabDireccion.Controls.Add(this.cmdListarBarrio);
            this.tabDireccion.Controls.Add(this.txtBarrio);
            this.tabDireccion.Controls.Add(this.lblBarrio);
            this.tabDireccion.Location = new System.Drawing.Point(4, 22);
            this.tabDireccion.Name = "tabDireccion";
            this.tabDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDireccion.Size = new System.Drawing.Size(450, 74);
            this.tabDireccion.TabIndex = 1;
            this.tabDireccion.Text = "Dirección";
            this.tabDireccion.UseVisualStyleBackColor = true;
            // 
            // cmdListarBarrio
            // 
            this.cmdListarBarrio.Location = new System.Drawing.Point(369, 45);
            this.cmdListarBarrio.Name = "cmdListarBarrio";
            this.cmdListarBarrio.Size = new System.Drawing.Size(75, 23);
            this.cmdListarBarrio.TabIndex = 3;
            this.cmdListarBarrio.Text = "Listar";
            this.cmdListarBarrio.UseVisualStyleBackColor = true;
            this.cmdListarBarrio.Click += new System.EventHandler(this.cmdListarBarrio_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(224, 28);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(100, 20);
            this.txtBarrio.TabIndex = 1;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(130, 31);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 0;
            this.lblBarrio.Text = "Barrio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(18, 120);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 2;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(375, 120);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(97, 23);
            this.cmdMostrar.TabIndex = 3;
            this.cmdMostrar.Text = "Mostrar todos";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 309);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Empleados";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabApellido.ResumeLayout(false);
            this.tabApellido.PerformLayout();
            this.tabDireccion.ResumeLayout(false);
            this.tabDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TabPage tabDireccion;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdListarBarrio;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdMostrar;
    }
}