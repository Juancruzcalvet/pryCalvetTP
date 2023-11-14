namespace PryTPCalvet
{
    partial class frmEdicionTexto
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
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.grpHerramientas = new System.Windows.Forms.GroupBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtModificiar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grpQuitar = new System.Windows.Forms.GroupBox();
            this.cmdCaracter = new System.Windows.Forms.Button();
            this.cmdEspacios = new System.Windows.Forms.Button();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.grpHerramientas.SuspendLayout();
            this.grpQuitar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(357, 144);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 1;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(438, 144);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 2;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(519, 144);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // grpHerramientas
            // 
            this.grpHerramientas.Controls.Add(this.lblModificar);
            this.grpHerramientas.Controls.Add(this.lblBuscar);
            this.grpHerramientas.Controls.Add(this.cmdModificar);
            this.grpHerramientas.Controls.Add(this.cmdBuscar);
            this.grpHerramientas.Controls.Add(this.txtModificiar);
            this.grpHerramientas.Controls.Add(this.txtBuscar);
            this.grpHerramientas.Location = new System.Drawing.Point(12, 188);
            this.grpHerramientas.Name = "grpHerramientas";
            this.grpHerramientas.Size = new System.Drawing.Size(384, 100);
            this.grpHerramientas.TabIndex = 4;
            this.grpHerramientas.TabStop = false;
            this.grpHerramientas.Text = "Herramientas";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(15, 68);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(50, 13);
            this.lblModificar.TabIndex = 9;
            this.lblModificar.Text = "Modificar";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 27);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(303, 63);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 7;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(303, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 6;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtModificiar
            // 
            this.txtModificiar.Location = new System.Drawing.Point(83, 65);
            this.txtModificiar.Name = "txtModificiar";
            this.txtModificiar.Size = new System.Drawing.Size(201, 20);
            this.txtModificiar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(83, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // grpQuitar
            // 
            this.grpQuitar.Controls.Add(this.cmdCaracter);
            this.grpQuitar.Controls.Add(this.cmdEspacios);
            this.grpQuitar.Controls.Add(this.txtCaracter);
            this.grpQuitar.Location = new System.Drawing.Point(402, 188);
            this.grpQuitar.Name = "grpQuitar";
            this.grpQuitar.Size = new System.Drawing.Size(200, 100);
            this.grpQuitar.TabIndex = 5;
            this.grpQuitar.TabStop = false;
            this.grpQuitar.Text = "Quitar";
            // 
            // cmdCaracter
            // 
            this.cmdCaracter.Location = new System.Drawing.Point(119, 22);
            this.cmdCaracter.Name = "cmdCaracter";
            this.cmdCaracter.Size = new System.Drawing.Size(75, 23);
            this.cmdCaracter.TabIndex = 8;
            this.cmdCaracter.Text = "Caracter";
            this.cmdCaracter.UseVisualStyleBackColor = true;
            this.cmdCaracter.Click += new System.EventHandler(this.cmdCaracter_Click);
            // 
            // cmdEspacios
            // 
            this.cmdEspacios.Location = new System.Drawing.Point(119, 63);
            this.cmdEspacios.Name = "cmdEspacios";
            this.cmdEspacios.Size = new System.Drawing.Size(75, 23);
            this.cmdEspacios.TabIndex = 9;
            this.cmdEspacios.Text = "Espacios";
            this.cmdEspacios.UseVisualStyleBackColor = true;
            this.cmdEspacios.Click += new System.EventHandler(this.cmdEspacios_Click);
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(6, 24);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(100, 20);
            this.txtCaracter.TabIndex = 2;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(12, 291);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(126, 13);
            this.lblContador.TabIndex = 10;
            this.lblContador.Text = "Cantidad de caracteres: -";
            // 
            // rtxTexto
            // 
            this.rtxTexto.Location = new System.Drawing.Point(15, 12);
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.Size = new System.Drawing.Size(581, 126);
            this.rtxTexto.TabIndex = 11;
            this.rtxTexto.Text = "";
            this.rtxTexto.TextChanged += new System.EventHandler(this.rtxTexto_TextChanged);
            // 
            // frmEdicionTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 327);
            this.Controls.Add(this.rtxTexto);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.grpQuitar);
            this.Controls.Add(this.grpHerramientas);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdCancelar);
            this.Name = "frmEdicionTexto";
            this.Text = "Editor texto";
            this.grpHerramientas.ResumeLayout(false);
            this.grpHerramientas.PerformLayout();
            this.grpQuitar.ResumeLayout(false);
            this.grpQuitar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox grpHerramientas;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtModificiar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox grpQuitar;
        private System.Windows.Forms.Button cmdCaracter;
        private System.Windows.Forms.Button cmdEspacios;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.RichTextBox rtxTexto;
    }
}