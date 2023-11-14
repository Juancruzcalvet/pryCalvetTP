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
    public partial class frmListado : Form
    {
        clsInicio objInicio;
        public frmListado()
        {
            InitializeComponent();
            objInicio = new clsInicio();
            objInicio.ConectarBD();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            int i = 1;
            objInicio.Buscar(txtApellido.Text, dataGridView1, i);

        }

        private void cmdListarBarrio_Click(object sender, EventArgs e)
        {
            int i = 3;
            objInicio.Buscar(txtBarrio.Text, dataGridView1, i);
        }
    }
}
