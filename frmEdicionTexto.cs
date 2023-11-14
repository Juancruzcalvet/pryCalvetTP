using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PryTPCalvet
{
    public partial class frmEdicionTexto : Form
    {
        
        

        
        public frmEdicionTexto()
        {
            InitializeComponent();
        }
        string buscar = "";
        string modificiar = "";
        string caracter = "";
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            buscar = txtBuscar.Text;
            modificiar = txtModificiar.Text;
            
            
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            buscar = txtBuscar.Text;
            rtxTexto.Focus();
            rtxTexto.SelectionStart = buscar.Length;
            rtxTexto.ScrollToCaret();
        }

        private void rtxTexto_TextChanged(object sender, EventArgs e)
        {
            lblContador.Text = "Cantidad de caraceteres: " + (rtxTexto.Text.Length);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
