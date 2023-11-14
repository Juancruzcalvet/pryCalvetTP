using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTPCalvet
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void registradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
