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
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            buscar = txtBuscar.Text;
            modificiar = txtModificiar.Text;

            rtxTexto.Text = rtxTexto.Text.Replace(buscar, modificiar);



        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            buscar = txtBuscar.Text;
            string[] words = buscar.Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < rtxTexto.TextLength)
                {
                    int wordstartIndex = rtxTexto.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        rtxTexto.SelectionStart = wordstartIndex;
                        rtxTexto.SelectionLength = word.Length;
                        rtxTexto.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }
        }

        private void rtxTexto_TextChanged(object sender, EventArgs e)
        {
            lblContador.Text = "Cantidad de caraceteres: " + (rtxTexto.Text.Length);
        }


        private void cmdCaracter_Click(object sender, EventArgs e)
        {
            rtxTexto.Text = rtxTexto.Text.Replace(txtCaracter.Text, "");
        }

        private void cmdEspacios_Click(object sender, EventArgs e)
        {
            rtxTexto.Text = rtxTexto.Text.Replace(" ", "");
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            rtxTexto.Text = "";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string sw = "Texto.secreto";
            StreamWriter Escribir = new StreamWriter(sw, false);
            Escribir.Write(rtxTexto.Text);
            MessageBox.Show("Guardado");

        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();

        }

        private void frmEdicionTexto_Load(object sender, EventArgs e)
        {
        }
    }
    
}
