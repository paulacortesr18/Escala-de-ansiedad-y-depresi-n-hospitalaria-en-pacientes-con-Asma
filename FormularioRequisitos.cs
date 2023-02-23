using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion
{
    public partial class FormularioDeRequisitos : Form
    {
        public FormularioDeRequisitos()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            var frm = new Escala_Ansiedad_Depresión_Hospitalaria();
            frm.Show();
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
