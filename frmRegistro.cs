using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PryTPCalvet
{
    public partial class frmRegistro : Form
    {
        clsInicio objInicio;
        public frmRegistro()
        {
            InitializeComponent();
            objInicio = new clsInicio();
            objInicio.ConectarBD();
        }
        


        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
            e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }

          

        }
        string Nombre = "";
        string Apellido = "";
        string Direccion = "";
        string Ciudad = "";
        string Telefono = "";
        DateTime Nacimiento ;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Direccion = txtBarrio.Text + txtCalle.Text;
            Ciudad = txtCiudad.Text;
            Nacimiento = dtpNacimiento.Value;
            objInicio.CrearUsuario(Nombre, Apellido, Direccion, Ciudad, Telefono, Nacimiento);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
